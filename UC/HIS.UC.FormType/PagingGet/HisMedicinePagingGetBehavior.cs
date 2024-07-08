/* IVT
 * @Project : hisnguonmo
 * Copyright (C) 2017 INVENTEC
 *  
 * This program is free software: you can redistribute it and/or modify
 * it under the terms of the GNU General Public License as published by
 * the Free Software Foundation, either version 3 of the License, or
 * (at your option) any later version.
 *  
 * This program is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.See the
 * GNU General Public License for more details.
 *  
 * You should have received a copy of the GNU General Public License
 * along with this program. If not, see <http://www.gnu.org/licenses/>.
 */
using HIS.UC.FormType.HisMultiGetString;
using Inventec.Core;
using MOS.EFMODEL.DataModels;
using MOS.Filter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.UC.FormType.PagingGet
{
    class HisMedicinePagingGetBehavior:IPagingGet
    {
        string _keyWord;
        long? _parentKey;
        CommonParam _param;
        internal HisMedicinePagingGetBehavior(CommonParam param, string keyWord, long? parentKey)
        {
            this._keyWord = keyWord;
            this._parentKey = parentKey;
            this._param = param;
        }

        ApiResultObject<List<HIS.UC.FormType.HisMultiGetString.DataGet>> IPagingGet.Run()
        {
            ApiResultObject<List<HIS.UC.FormType.HisMultiGetString.DataGet>> result = new ApiResultObject<List<DataGet>>();
            try
            {
                ApiResultObject<List<MOS.EFMODEL.DataModels.V_HIS_MEDICINE_1>> apiResult = new ApiResultObject<List<V_HIS_MEDICINE_1>>();
                object Medicine = apiResult;
                HisMedicineView1Filter filter = new HisMedicineView1Filter();
                if (!string.IsNullOrWhiteSpace(_keyWord))
                {
                    //string code = _keyWord.Trim();
                    //if (code.Length < 12 && checkDigit(code))
                    //{
                    //    code = string.Format("{0:000000000000}", Convert.ToInt64(code));
                    //}
                    filter.KEY_WORD = _keyWord;
                }
                //filter.MEDICINE_TYPE_CODE__EXACT = "_";
                if (_parentKey != null)
                {
                    List<DataGet> medicineTypes = HisMultiGetByString.GetByString("HIS_MEDICINE_TYPE", null);
                    if (medicineTypes != null)
                    {
                        var medicineType = medicineTypes.FirstOrDefault(o=>o.ID==_parentKey);
                        if (medicineType != null)
                        {
                            filter.MEDICINE_TYPE_CODE__EXACT = medicineType.CODE;
                        }
                    }
                }
                object ft = filter;
                FormTypeDelegate.PagingGet(this._param, ft, ref Medicine);
                apiResult = Medicine as ApiResultObject<List<MOS.EFMODEL.DataModels.V_HIS_MEDICINE_1>>;
                if (apiResult != null)
                {
                    result.Data = apiResult.Data.Select(o => new DataGet { ID = o.ID, CODE = o.PACKAGE_NUMBER +" - "+o.MEDICINE_TYPE_CODE, NAME = o.SUPPLIER_NAME +" - "+o.MEDICINE_TYPE_NAME }).ToList();
                    result.Param = apiResult.Param;
                }
            }
            catch (Exception ex)
            {
                Inventec.Common.Logging.LogSystem.Error(ex);
                result = null;
            }
            return result;
        }

        private  bool checkDigit(string s)
        {
            bool result = true;
            try
            {
                for (int i = 0; i < s.Length; i++)
                {
                    if (char.IsDigit(s[i]) != true)
                    {
                        result = false;
                        break;
                    }
                }
                return result;
            }
            catch (Exception ex)
            {
                Inventec.Common.Logging.LogSystem.Error(ex);
                return result;
            }
        }
    }
}