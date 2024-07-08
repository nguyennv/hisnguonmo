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
using HIS.UC.CreateReport.Base;
using HIS.UC.FormType.Core.Checkbox;
using Inventec.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DCV.APP.Report.JsonOutput
{
    class JsonOutputCheckBehavior: BussinessBase, IJsonOutput
    {
        UCCheck entity;
        internal JsonOutputCheckBehavior(CommonParam param, HIS.UC.FormType.Core.Checkbox.UCCheck filter)
            : base(param)
        {
            this.entity = filter;
        }

        string IJsonOutput.Run()
        {
            string result = "";
            try
            {
                result = entity.GetValue();

            }
            catch (Exception ex)
            {
                Inventec.Common.Logging.LogSystem.Error(ex);
                param.HasException = true;
                result = "";
            }
            return result;
}
    }
}