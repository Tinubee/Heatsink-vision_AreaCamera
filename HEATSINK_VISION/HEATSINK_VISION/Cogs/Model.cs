using Cognex.VisionPro;
using Cognex.VisionPro.Dimensioning;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace HEATSINK_VISION.Cogs
{
    public class Model
    {
        private Global Glob = Global.getInstance;
        // 모델 기초 자료
        private string Name; // 모델 명
        private int Number; // 모델 번호

        public const int MULTIPATTERNMAX = 30;
        public const int BLOBTOOLMAX = 30;

        public Model()
        {

        }
        /// <summary>
        /// 모델 이름으로 모델 교체
        /// </summary>
        /// <param name="Name"></param>
        /// <param name="ModelRoot"></param>
        /// <returns></returns>
        public bool Loadmodel(string Name, string ModelRoot, int camnumber, bool isFirst = false)
        {
            INIControl Modellist;
            INIControl CFGFILE;

            Modellist = new INIControl(Glob.MODELLIST);
            CFGFILE = new INIControl(Glob.CONFIGFILE);

            string CHKName;
            int CHKNumber;

            CHKNumber = int.Parse(Modellist.ReadData("NAME", Name, true));
            CHKName = Modellist.ReadData("NUMBER", CHKNumber.ToString(), false);

            if (Directory.Exists(ModelRoot) == false)
            {
                return false;
            }

            ModelRoot += "\\" + CHKName + $"\\Cam{camnumber}"; //각 Camera별 Vision Tool .vpp 파일 경로.

            if (Directory.Exists(ModelRoot) == false)
            {
                Directory.CreateDirectory(ModelRoot);
                //eturn false;
            }

            if (Read(ModelRoot, camnumber) == false)
            {
                if (isFirst == false)
                {
                    return false;
                }
            }

            this.Name = CHKName;
            Number = CHKNumber;

            CFGFILE.WriteData("LASTMODEL", "NAME", this.Name);
            CFGFILE.WriteData("LASTMODEL", "NUMBER", Number.ToString());
            return true;
        }

        /// <summary>
        /// 검사 모델 파일 불러오기
        /// </summary>
        /// <param name="path">경로</param>
        /// <returns></returns>
        private bool Read(string path, int cam)
        {
            GC.Collect();
            // 실제 모델 전환하는 메소드
            INIControl Modelcfg = new INIControl(path + Glob.MODELCONFIGFILE);

            return true;
        }

        public CogImage8Grey Imageconvert(Cognex.VisionPro.CogImage24PlanarColor image)
        {
            if (image == null)
            {
                return null;
            }

            Cognex.VisionPro.ImageProcessing.CogImageConvertTool Tool = new Cognex.VisionPro.ImageProcessing.CogImageConvertTool();
            Tool.RunParams.RunMode = Cognex.VisionPro.ImageProcessing.CogImageConvertRunModeConstants.Plane0;

            Tool.InputImage = image;
            Tool.Run();
            return (CogImage8Grey)Tool.OutputImage;
        }

        /// <summary>
        /// 현재 모델을 파일에 저장
        /// </summary>
        /// <param name="path">경로</param>
        /// <returns></returns>
        public bool SaveModel(string path, int cam)
        {
            INIControl Modelcfg = new INIControl(path + Glob.MODELCONFIGFILE);

            return true;
        }
        public string Modelname()
        {
            // 현재 모델 명
            return Name;
        }

        public int ModelNumber()
        {
            // 현재 모델 번호
            return this.Number;
        }
    }
}
