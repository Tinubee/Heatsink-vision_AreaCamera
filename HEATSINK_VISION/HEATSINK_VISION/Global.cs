using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HEATSINK_VISION
{
    public class Global
    {
        #region "DO NOT TOUCH"
        private static Global instance = null;
        private static readonly object Lock = new object();

        private Global()
        {

        }

        public static Global getInstance
        {
            get
            {
                lock (Lock)
                {
                    if (instance == null)
                    {
                        instance = new Global();
                    }
                    return instance;
                }
            }
        }
        #endregion

        public readonly string PROGRAMROOT = Application.StartupPath;

        public readonly string MODELROOT = Application.StartupPath + "\\Models"; //모델저장경로.
        public readonly string MODELLIST = Application.StartupPath + "\\ModelList.ini"; //모델리스트 ini파일

        public readonly string MODELCONFIGFILE = "\\Modelcfg.ini"; //모델 사용유무 저장.

        public readonly string CONFIGFILE = Application.StartupPath + "\\config.ini";
        public readonly string SETTING = Application.StartupPath + "\\setting.ini"; //setting값 저장

        public readonly string MasterImageFilePath = Application.StartupPath + "\\Models";
        public readonly string PROGRAM_VERSION = "1.0.0"; //Program Version
    }

    public struct CamSets
    {
        public double Exposure; //조리개값
        public double Gain;
        public int DelayTime; //지연시간
    }
}
