﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventec.Common.WordContent.License
{
    internal class LicenceProcess
    {
        internal static void SetLicenseForAspose()
        {
            try
            {
                if (!String.IsNullOrEmpty(Licenses.Aspose_Key))
                {
                    Stream Aspose_LStream = (Stream)new MemoryStream(Convert.FromBase64String(Licenses.Aspose_Key));
                    Aspose.Words.License license = new Aspose.Words.License();
                    license.SetLicense(Aspose_LStream);
                }
            }
            catch (Exception ex)
            {
                Inventec.Common.Logging.LogSystem.Warn(ex);
            }
        }
    }
}