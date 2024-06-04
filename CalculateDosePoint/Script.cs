using System;
using System.Windows;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using VMS.TPS.Common.Model.API;
using VMS.TPS.Common.Model.Types;
using System.Windows.Media.Media3D;
using System.Configuration;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace VMS.TPS
{
    public class Script
    {
        public void Execute(ScriptContext context)
        {
            run(context.IonPlanSetup, context.Patient);
        }
        public void run(IonPlanSetup plan, Patient patient)
        {
            CSI_GUI.MainForm form = new CSI_GUI.MainForm(plan);
            form.ShowDialog();
        }
    }
}

