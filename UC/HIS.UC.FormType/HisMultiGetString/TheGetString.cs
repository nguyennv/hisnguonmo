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
using Inventec.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.UC.FormType.HisMultiGetString
{
    public class TheGetString
    {
        public static List<DataGet> Get(string value, string key)
        {
            List<DataGet> datasuft = null;
            try
            {
                if (value == null) return new List<DataGet>();

                else if (value == "THE_BRANCH")
                {
                    datasuft = Config.TheFormTypeConfig.TheBranchs.Select(o => new DataGet { ID = o.ID, CODE = o.BRANCH_CODE, NAME = o.BRANCH_NAME }).ToList();
                }
                else if (value == "THE_BANK_BRANCH")
                {
                    datasuft = Config.TheFormTypeConfig.TheBranchs.Where(p => !string.IsNullOrWhiteSpace(p.BANK_BRANCH_CODE)).GroupBy(p => p.BANK_BRANCH_CODE).Select(o => new DataGet { ID = o.First().ID, CODE = o.First().BANK_BRANCH_CODE, NAME = o.First().BANK_NAME }).ToList();
                }

                datasuft = datasuft.OrderBy(o => o.NAME).ToList();
            }
            catch (Exception ex)
            {
                Inventec.Common.Logging.LogSystem.Error(ex);
            }
            return datasuft;
        }
    }
}
