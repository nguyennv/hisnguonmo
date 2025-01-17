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
using DevExpress.XtraGrid.Columns;
using HIS.Desktop.LocalStorage.BackendData;
using MOS.EFMODEL.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.Desktop.Plugins.HisTranPatiOutInfo.ProcessLoadDataCombo
{
    public class ProcessLoad
    {
        public static void LoadDataToComboMediOrg(DevExpress.XtraEditors.GridLookUpEdit cboMediOrg, object data)
        {
            try
            {
                cboMediOrg.Properties.DataSource = data;
                cboMediOrg.Properties.DisplayMember = "MEDI_ORG_NAME";
                cboMediOrg.Properties.ValueMember = "MEDI_ORG_CODE";

                cboMediOrg.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
                cboMediOrg.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains;
                cboMediOrg.Properties.ImmediatePopup = true;
                cboMediOrg.ForceInitialize();
                cboMediOrg.Properties.View.Columns.Clear();

                GridColumn aColumnCode = cboMediOrg.Properties.View.Columns.AddField("MEDI_ORG_CODE");
                aColumnCode.Caption = "Mã";
                aColumnCode.Visible = true;
                aColumnCode.VisibleIndex = 1;
                aColumnCode.Width = 100;

                GridColumn aColumnName = cboMediOrg.Properties.View.Columns.AddField("MEDI_ORG_NAME");
                aColumnName.Caption = "Tên";
                aColumnName.Visible = true;
                aColumnName.VisibleIndex = 2;
                aColumnName.Width = 200;
            }
            catch (Exception ex)
            {
                Inventec.Common.Logging.LogSystem.Warn(ex);
            }
        }

        public static void LoadDataToComboTranPatiReason(DevExpress.XtraEditors.GridLookUpEdit cboTranPatiReason, object data)
        {
            try
            {
                cboTranPatiReason.Properties.DataSource = data;
                cboTranPatiReason.Properties.DisplayMember = "TRAN_PATI_REASON_NAME";
                cboTranPatiReason.Properties.ValueMember = "ID";

                cboTranPatiReason.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
                cboTranPatiReason.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains;
                cboTranPatiReason.Properties.ImmediatePopup = true;
                cboTranPatiReason.ForceInitialize();
                cboTranPatiReason.Properties.View.Columns.Clear();

                GridColumn aColumnCode = cboTranPatiReason.Properties.View.Columns.AddField("TRAN_PATI_REASON_CODE");
                aColumnCode.Caption = "Mã";
                aColumnCode.Visible = true;
                aColumnCode.VisibleIndex = 1;
                aColumnCode.Width = 100;

                GridColumn aColumnName = cboTranPatiReason.Properties.View.Columns.AddField("TRAN_PATI_REASON_NAME");
                aColumnName.Caption = "Lý do chuyển viện";
                aColumnName.Visible = true;
                aColumnName.VisibleIndex = 2;
                aColumnName.Width = 500;
            }
            catch (Exception ex)
            {
                Inventec.Common.Logging.LogSystem.Warn(ex);
            }
        }

        public static void LoadDataToComboTranPatiForm(DevExpress.XtraEditors.GridLookUpEdit cboTranPatiForm, object data)
        {
            try
            {
                cboTranPatiForm.Properties.DataSource = data;
                cboTranPatiForm.Properties.DisplayMember = "TRAN_PATI_FORM_NAME";
                cboTranPatiForm.Properties.ValueMember = "ID";

                cboTranPatiForm.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
                cboTranPatiForm.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains;
                cboTranPatiForm.Properties.ImmediatePopup = true;
                cboTranPatiForm.ForceInitialize();
                cboTranPatiForm.Properties.View.Columns.Clear();

                GridColumn aColumnCode = cboTranPatiForm.Properties.View.Columns.AddField("TRAN_PATI_FORM_CODE");
                aColumnCode.Caption = "Mã";
                aColumnCode.Visible = true;
                aColumnCode.VisibleIndex = 1;
                aColumnCode.Width = 100;

                GridColumn aColumnName = cboTranPatiForm.Properties.View.Columns.AddField("TRAN_PATI_FORM_NAME");
                aColumnName.Caption = "Hình thức chuyển viện";
                aColumnName.Visible = true;
                aColumnName.VisibleIndex = 2;
                aColumnName.Width = 500;
            }
            catch (Exception ex)
            {
                Inventec.Common.Logging.LogSystem.Warn(ex);
            }
        }

        internal static void LoadComboTranPatiReason(string searchCode, bool isExpand, DevExpress.XtraEditors.GridLookUpEdit cboTranPatiReason, DevExpress.XtraEditors.TextEdit txtTranPatiReason, DevExpress.XtraEditors.TextEdit txtTranPatiForm)
        {
            try
            {
                if (String.IsNullOrEmpty(searchCode))
                {
                    cboTranPatiReason.EditValue = null;
                    cboTranPatiReason.Focus();
                    cboTranPatiReason.ShowPopup();
                }
                else
                {
                    var data = BackendDataWorker.Get<HIS_TRAN_PATI_REASON>().Where(o => o.TRAN_PATI_REASON_CODE.Contains(searchCode)).ToList();
                    if (data != null)
                    {
                        if (data.Count == 1)
                        {
                            cboTranPatiReason.EditValue = data[0].ID;
                            txtTranPatiReason.Text = data[0].TRAN_PATI_REASON_CODE;
                            txtTranPatiForm.Focus();
                            txtTranPatiForm.SelectAll();
                        }
                        else if (data.Count > 1)
                        {
                            cboTranPatiReason.EditValue = null;
                            cboTranPatiReason.Focus();
                            cboTranPatiReason.ShowPopup();
                            //PopupProcess.SelectFirstRowPopup(control.cboMediOrg);
                        }
                    }
                    else
                    {
                        cboTranPatiReason.EditValue = null;
                        cboTranPatiReason.Focus();
                        cboTranPatiReason.ShowPopup();
                        //PopupProcess.SelectFirstRowPopup(control.cboMediOrg);
                    }
                }
            }
            catch (Exception ex)
            {
                Inventec.Common.Logging.LogSystem.Warn(ex);
            }
        }

        internal static void LoadNoiDKKCBBDCombo(string searchCode, bool isExpand, DevExpress.XtraEditors.GridLookUpEdit cboMediOrg, DevExpress.XtraEditors.TextEdit txtMediOrg, DevExpress.XtraEditors.LabelControl lblMediOrg_Address, DevExpress.XtraEditors.TextEdit focusControl)
        {
            try
            {
                if (String.IsNullOrEmpty(searchCode))
                {
                    cboMediOrg.EditValue = null;
                    cboMediOrg.Focus();
                    cboMediOrg.ShowPopup();
                    //PopupProcess.SelectFirstRowPopup(control.cboBlood);
                    //lblMediOrg_Address.Text = "";
                }
                else
                {
                    var data = BackendDataWorker.Get<HIS_MEDI_ORG>().Where(o => o.MEDI_ORG_CODE.Contains(searchCode)).ToList();
                    if (data != null)
                    {
                        if (data.Count == 1)
                        {
                           // cboMediOrg.Properties.Buttons[1].Visible = true;
                            cboMediOrg.EditValue = data[0].MEDI_ORG_CODE;
                            txtMediOrg.Text = data[0].MEDI_ORG_CODE;
                            //lblMediOrg_Address.Text = data[0].Address;
                            focusControl.Focus();
                            focusControl.SelectAll();
                        }
                        else if (data.Count > 1)
                        {
                            cboMediOrg.EditValue = null;
                            cboMediOrg.Focus();
                            cboMediOrg.ShowPopup();
                            //PopupProcess.SelectFirstRowPopup(control.cboMediOrg);
                        }
                    }
                    else
                    {
                        cboMediOrg.EditValue = null;
                        cboMediOrg.Focus();
                        cboMediOrg.ShowPopup();
                        //PopupProcess.SelectFirstRowPopup(control.cboMediOrg);
                    }
                }
            }
            catch (Exception ex)
            {
                Inventec.Common.Logging.LogSystem.Warn(ex);
            }
        }

        internal static void LoadComboTranPatiForm(string searchCode, bool isExpand, DevExpress.XtraEditors.GridLookUpEdit cboTranPatiForm, DevExpress.XtraEditors.TextEdit txtTranPatiForm, DevExpress.XtraEditors.TextEdit txtDauHieuLamSang)
        {
            try
            {
                if (String.IsNullOrEmpty(searchCode))
                {
                    cboTranPatiForm.EditValue = null;
                    cboTranPatiForm.Focus();
                    cboTranPatiForm.ShowPopup();
                }
                else
                {
                    var data = BackendDataWorker.Get<HIS_TRAN_PATI_FORM>().Where(o => o.TRAN_PATI_FORM_CODE.Contains(searchCode)).ToList();
                    if (data != null)
                    {
                        if (data.Count == 1)
                        {
                            cboTranPatiForm.EditValue = data[0].ID;
                            txtTranPatiForm.Text = data[0].TRAN_PATI_FORM_CODE;
                            txtTranPatiForm.Focus();
                            txtTranPatiForm.SelectAll();
                            //cboTranPatiForm.Properties.Buttons[1].Visible = true;
                        }
                        else if (data.Count > 1)
                        {
                            cboTranPatiForm.EditValue = null;
                            cboTranPatiForm.Focus();
                            cboTranPatiForm.ShowPopup();
                            //PopupProcess.SelectFirstRowPopup(control.cboMediOrg);
                        }
                    }
                    else
                    {
                        cboTranPatiForm.EditValue = null;
                        cboTranPatiForm.Focus();
                        cboTranPatiForm.ShowPopup();
                        //PopupProcess.SelectFirstRowPopup(control.cboMediOrg);
                    }
                }
            }
            catch (Exception ex)
            {
                Inventec.Common.Logging.LogSystem.Warn(ex);
            }
        }

    }
}
