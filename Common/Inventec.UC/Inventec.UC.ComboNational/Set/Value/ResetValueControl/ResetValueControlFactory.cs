﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventec.UC.ComboNational.Set.Value.ResetValueControl
{
    class ResetValueControlFactory
    {
        internal static IResetValueControl MakeIResetValueControl()
        {
            IResetValueControl result = null;
            try
            {
                result = new ResetValueControl();
            }
            catch (Exception ex)
            {
                Inventec.Common.Logging.LogSystem.Error(ex);
                result = null;
            }
            return result;
        }
    }
}