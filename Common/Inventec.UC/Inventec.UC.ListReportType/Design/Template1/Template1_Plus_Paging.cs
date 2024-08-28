﻿using Inventec.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventec.UC.ListReportType.Design.Template1
{
    internal partial class Template1
    {
        internal void SetInitPaging()
        {
            try
            {
                CommonParam param = new CommonParam();
                param.Limit = rowCount;
                param.Count = dataTotal;
                ucPaging1.Init(FillDataToGridControl, param, pageSize, this.gridControlReportType);
            }
            catch (Exception ex)
            {
                Inventec.Common.Logging.LogSystem.Error(ex);
            }
        }

        internal void FillDataToGridControl(object param)
        {
            try
            {
                Data.SearchData data = new Data.SearchData();
                SetSearchData(data);
                CommonParam resultParam = new CommonParam();
                if (_updateData != null)
                {
                    gridViewReportType.BeginUpdate();
                    gridViewReportType.GridControl.DataSource = _updateData(data, param, ref resultParam);
                    gridViewReportType.EndUpdate();
                    rowCount = resultParam.Limit ?? 0;
                    dataTotal = resultParam.Count ?? 0;
                }
                else
                {
                    rowCount = 0;
                    dataTotal = 0;
                }
            }
            catch (Exception ex)
            {
                Inventec.Common.Logging.LogSystem.Error(ex);
            }
        }
    }
}
