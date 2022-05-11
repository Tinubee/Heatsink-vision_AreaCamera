namespace HEATSINK_VISION
{
    partial class formMain
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formMain));
            this.tlpTopSide = new System.Windows.Forms.TableLayoutPanel();
            this.lb_Mode = new System.Windows.Forms.Label();
            this.lb_CurruntModelName = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lb_Time = new System.Windows.Forms.Label();
            this.lb_Ver = new System.Windows.Forms.Label();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.btn_Stop = new System.Windows.Forms.Button();
            this.btn_Status = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lb_PLCStats = new System.Windows.Forms.Label();
            this.logControl1 = new KimLib.LogControl();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();
            this.cdyDisplay3 = new Cognex.VisionPro.Display.CogDisplay();
            this.tableLayoutPanel13 = new System.Windows.Forms.TableLayoutPanel();
            this.lb_Cam3_Result = new System.Windows.Forms.Label();
            this.lb_Cam3Stats = new System.Windows.Forms.Label();
            this.lb_Cam3_InsTime = new System.Windows.Forms.Label();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.cdyDisplay2 = new Cognex.VisionPro.Display.CogDisplay();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.lb_Cam2_Result = new System.Windows.Forms.Label();
            this.lb_Cam2Stats = new System.Windows.Forms.Label();
            this.lb_Cam2_InsTime = new System.Windows.Forms.Label();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.cdyDisplay = new Cognex.VisionPro.Display.CogDisplay();
            this.tableLayoutPanel10 = new System.Windows.Forms.TableLayoutPanel();
            this.lb_Cam1Stats = new System.Windows.Forms.Label();
            this.lb_Cam1_Result = new System.Windows.Forms.Label();
            this.lb_Cam1_InsTime = new System.Windows.Forms.Label();
            this.tlpUnder = new System.Windows.Forms.TableLayoutPanel();
            this.btn_SystemSetup = new System.Windows.Forms.Button();
            this.btn_ToolSetUp = new System.Windows.Forms.Button();
            this.btn_Model = new System.Windows.Forms.Button();
            this.btn_CamSet = new System.Windows.Forms.Button();
            this.tlpTopSide.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cdyDisplay3)).BeginInit();
            this.tableLayoutPanel13.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cdyDisplay2)).BeginInit();
            this.tableLayoutPanel6.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cdyDisplay)).BeginInit();
            this.tableLayoutPanel10.SuspendLayout();
            this.tlpUnder.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpTopSide
            // 
            this.tlpTopSide.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tlpTopSide.ColumnCount = 9;
            this.tlpTopSide.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.08826F));
            this.tlpTopSide.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.77986F));
            this.tlpTopSide.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34.21735F));
            this.tlpTopSide.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.561666F));
            this.tlpTopSide.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.557187F));
            this.tlpTopSide.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.554338F));
            this.tlpTopSide.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.414443F));
            this.tlpTopSide.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.414443F));
            this.tlpTopSide.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.412449F));
            this.tlpTopSide.Controls.Add(this.lb_Mode, 4, 0);
            this.tlpTopSide.Controls.Add(this.lb_CurruntModelName, 5, 0);
            this.tlpTopSide.Controls.Add(this.tableLayoutPanel1, 1, 0);
            this.tlpTopSide.Controls.Add(this.btn_Exit, 8, 0);
            this.tlpTopSide.Controls.Add(this.btn_Stop, 7, 0);
            this.tlpTopSide.Controls.Add(this.btn_Status, 6, 0);
            this.tlpTopSide.Controls.Add(this.pictureBox1, 0, 0);
            this.tlpTopSide.Controls.Add(this.label1, 2, 0);
            this.tlpTopSide.Controls.Add(this.lb_PLCStats, 3, 0);
            this.tlpTopSide.Dock = System.Windows.Forms.DockStyle.Top;
            this.tlpTopSide.Location = new System.Drawing.Point(0, 0);
            this.tlpTopSide.Name = "tlpTopSide";
            this.tlpTopSide.RowCount = 1;
            this.tlpTopSide.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpTopSide.Size = new System.Drawing.Size(2176, 77);
            this.tlpTopSide.TabIndex = 3;
            // 
            // lb_Mode
            // 
            this.lb_Mode.AutoSize = true;
            this.lb_Mode.BackColor = System.Drawing.SystemColors.Control;
            this.lb_Mode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Mode.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb_Mode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lb_Mode.Location = new System.Drawing.Point(1450, 1);
            this.lb_Mode.Name = "lb_Mode";
            this.lb_Mode.Size = new System.Drawing.Size(179, 75);
            this.lb_Mode.TabIndex = 31;
            this.lb_Mode.Text = "AUTORUN";
            this.lb_Mode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_CurruntModelName
            // 
            this.lb_CurruntModelName.AutoSize = true;
            this.lb_CurruntModelName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lb_CurruntModelName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_CurruntModelName.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb_CurruntModelName.Location = new System.Drawing.Point(1636, 1);
            this.lb_CurruntModelName.Name = "lb_CurruntModelName";
            this.lb_CurruntModelName.Size = new System.Drawing.Size(179, 75);
            this.lb_CurruntModelName.TabIndex = 1;
            this.lb_CurruntModelName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.lb_Time, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lb_Ver, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(245, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(270, 69);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // lb_Time
            // 
            this.lb_Time.AutoSize = true;
            this.lb_Time.BackColor = System.Drawing.Color.Black;
            this.lb_Time.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Time.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb_Time.ForeColor = System.Drawing.Color.White;
            this.lb_Time.Location = new System.Drawing.Point(4, 1);
            this.lb_Time.Name = "lb_Time";
            this.lb_Time.Size = new System.Drawing.Size(262, 33);
            this.lb_Time.TabIndex = 0;
            this.lb_Time.Text = "0000-00-00 오전 00:00:00";
            this.lb_Time.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_Ver
            // 
            this.lb_Ver.AutoSize = true;
            this.lb_Ver.BackColor = System.Drawing.Color.Black;
            this.lb_Ver.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Ver.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb_Ver.ForeColor = System.Drawing.Color.White;
            this.lb_Ver.Location = new System.Drawing.Point(4, 35);
            this.lb_Ver.Name = "lb_Ver";
            this.lb_Ver.Size = new System.Drawing.Size(262, 33);
            this.lb_Ver.TabIndex = 4;
            this.lb_Ver.Text = "Ver. 1.0.0";
            this.lb_Ver.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_Exit
            // 
            this.btn_Exit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Exit.Location = new System.Drawing.Point(2058, 4);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(114, 69);
            this.btn_Exit.TabIndex = 0;
            this.btn_Exit.UseVisualStyleBackColor = true;
            // 
            // btn_Stop
            // 
            this.btn_Stop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Stop.Location = new System.Drawing.Point(1940, 4);
            this.btn_Stop.Name = "btn_Stop";
            this.btn_Stop.Size = new System.Drawing.Size(111, 69);
            this.btn_Stop.TabIndex = 9;
            this.btn_Stop.UseVisualStyleBackColor = true;
            // 
            // btn_Status
            // 
            this.btn_Status.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Status.Location = new System.Drawing.Point(1822, 4);
            this.btn_Status.Name = "btn_Status";
            this.btn_Status.Size = new System.Drawing.Size(111, 69);
            this.btn_Status.TabIndex = 5;
            this.btn_Status.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(234, 69);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(522, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(735, 75);
            this.label1.TabIndex = 11;
            this.label1.Text = "GENTEX HEATSINK VISION PROGRAM";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_PLCStats
            // 
            this.lb_PLCStats.AutoSize = true;
            this.lb_PLCStats.BackColor = System.Drawing.SystemColors.Control;
            this.lb_PLCStats.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_PLCStats.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb_PLCStats.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lb_PLCStats.Location = new System.Drawing.Point(1264, 1);
            this.lb_PLCStats.Name = "lb_PLCStats";
            this.lb_PLCStats.Size = new System.Drawing.Size(179, 75);
            this.lb_PLCStats.TabIndex = 38;
            this.lb_PLCStats.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // logControl1
            // 
            this.logControl1.Color_ControlBack = System.Drawing.Color.Black;
            this.logControl1.Color_ErrorText = System.Drawing.Color.Red;
            this.logControl1.Color_NormalText = System.Drawing.Color.White;
            this.logControl1.Color_WarningText = System.Drawing.Color.Yellow;
            this.logControl1.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.logControl1.Location = new System.Drawing.Point(34, 679);
            this.logControl1.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.logControl1.Name = "logControl1";
            this.logControl1.Size = new System.Drawing.Size(520, 363);
            this.logControl1.TabIndex = 42;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel8, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel5, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel4, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 79);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1916, 573);
            this.tableLayoutPanel2.TabIndex = 43;
            // 
            // tableLayoutPanel8
            // 
            this.tableLayoutPanel8.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel8.ColumnCount = 1;
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel8.Controls.Add(this.cdyDisplay3, 0, 1);
            this.tableLayoutPanel8.Controls.Add(this.tableLayoutPanel13, 0, 0);
            this.tableLayoutPanel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel8.Location = new System.Drawing.Point(1280, 4);
            this.tableLayoutPanel8.Name = "tableLayoutPanel8";
            this.tableLayoutPanel8.RowCount = 2;
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 87F));
            this.tableLayoutPanel8.Size = new System.Drawing.Size(632, 565);
            this.tableLayoutPanel8.TabIndex = 20;
            // 
            // cdyDisplay3
            // 
            this.cdyDisplay3.ColorMapLowerClipColor = System.Drawing.Color.Black;
            this.cdyDisplay3.ColorMapLowerRoiLimit = 0D;
            this.cdyDisplay3.ColorMapPredefined = Cognex.VisionPro.Display.CogDisplayColorMapPredefinedConstants.None;
            this.cdyDisplay3.ColorMapUpperClipColor = System.Drawing.Color.Black;
            this.cdyDisplay3.ColorMapUpperRoiLimit = 1D;
            this.cdyDisplay3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cdyDisplay3.DoubleTapZoomCycleLength = 2;
            this.cdyDisplay3.DoubleTapZoomSensitivity = 2.5D;
            this.cdyDisplay3.Location = new System.Drawing.Point(4, 78);
            this.cdyDisplay3.MouseWheelMode = Cognex.VisionPro.Display.CogDisplayMouseWheelModeConstants.Zoom1;
            this.cdyDisplay3.MouseWheelSensitivity = 1D;
            this.cdyDisplay3.Name = "cdyDisplay3";
            this.cdyDisplay3.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("cdyDisplay3.OcxState")));
            this.cdyDisplay3.Size = new System.Drawing.Size(624, 483);
            this.cdyDisplay3.TabIndex = 8;
            // 
            // tableLayoutPanel13
            // 
            this.tableLayoutPanel13.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel13.ColumnCount = 3;
            this.tableLayoutPanel13.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel13.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel13.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel13.Controls.Add(this.lb_Cam3_Result, 1, 0);
            this.tableLayoutPanel13.Controls.Add(this.lb_Cam3Stats, 0, 0);
            this.tableLayoutPanel13.Controls.Add(this.lb_Cam3_InsTime, 2, 0);
            this.tableLayoutPanel13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel13.Location = new System.Drawing.Point(4, 4);
            this.tableLayoutPanel13.Name = "tableLayoutPanel13";
            this.tableLayoutPanel13.RowCount = 1;
            this.tableLayoutPanel13.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel13.Size = new System.Drawing.Size(624, 67);
            this.tableLayoutPanel13.TabIndex = 9;
            // 
            // lb_Cam3_Result
            // 
            this.lb_Cam3_Result.AutoSize = true;
            this.lb_Cam3_Result.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam3_Result.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb_Cam3_Result.Location = new System.Drawing.Point(129, 1);
            this.lb_Cam3_Result.Name = "lb_Cam3_Result";
            this.lb_Cam3_Result.Size = new System.Drawing.Size(304, 65);
            this.lb_Cam3_Result.TabIndex = 1;
            this.lb_Cam3_Result.Text = "Result";
            this.lb_Cam3_Result.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_Cam3Stats
            // 
            this.lb_Cam3Stats.AutoSize = true;
            this.lb_Cam3Stats.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam3Stats.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb_Cam3Stats.Location = new System.Drawing.Point(4, 1);
            this.lb_Cam3Stats.Name = "lb_Cam3Stats";
            this.lb_Cam3Stats.Size = new System.Drawing.Size(118, 65);
            this.lb_Cam3Stats.TabIndex = 0;
            this.lb_Cam3Stats.Tag = "3";
            this.lb_Cam3Stats.Text = "CAM 3";
            this.lb_Cam3Stats.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_Cam3_InsTime
            // 
            this.lb_Cam3_InsTime.AutoSize = true;
            this.lb_Cam3_InsTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam3_InsTime.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb_Cam3_InsTime.Location = new System.Drawing.Point(440, 1);
            this.lb_Cam3_InsTime.Name = "lb_Cam3_InsTime";
            this.lb_Cam3_InsTime.Size = new System.Drawing.Size(180, 65);
            this.lb_Cam3_InsTime.TabIndex = 2;
            this.lb_Cam3_InsTime.Text = "0 msec";
            this.lb_Cam3_InsTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel5.ColumnCount = 1;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Controls.Add(this.cdyDisplay2, 0, 1);
            this.tableLayoutPanel5.Controls.Add(this.tableLayoutPanel6, 0, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(642, 4);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 2;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 87F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(631, 565);
            this.tableLayoutPanel5.TabIndex = 19;
            // 
            // cdyDisplay2
            // 
            this.cdyDisplay2.ColorMapLowerClipColor = System.Drawing.Color.Black;
            this.cdyDisplay2.ColorMapLowerRoiLimit = 0D;
            this.cdyDisplay2.ColorMapPredefined = Cognex.VisionPro.Display.CogDisplayColorMapPredefinedConstants.None;
            this.cdyDisplay2.ColorMapUpperClipColor = System.Drawing.Color.Black;
            this.cdyDisplay2.ColorMapUpperRoiLimit = 1D;
            this.cdyDisplay2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cdyDisplay2.DoubleTapZoomCycleLength = 2;
            this.cdyDisplay2.DoubleTapZoomSensitivity = 2.5D;
            this.cdyDisplay2.Location = new System.Drawing.Point(4, 78);
            this.cdyDisplay2.MouseWheelMode = Cognex.VisionPro.Display.CogDisplayMouseWheelModeConstants.Zoom1;
            this.cdyDisplay2.MouseWheelSensitivity = 1D;
            this.cdyDisplay2.Name = "cdyDisplay2";
            this.cdyDisplay2.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("cdyDisplay2.OcxState")));
            this.cdyDisplay2.Size = new System.Drawing.Size(623, 483);
            this.cdyDisplay2.TabIndex = 8;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel6.ColumnCount = 3;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel6.Controls.Add(this.lb_Cam2_Result, 1, 0);
            this.tableLayoutPanel6.Controls.Add(this.lb_Cam2Stats, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.lb_Cam2_InsTime, 2, 0);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(4, 4);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 1;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(623, 67);
            this.tableLayoutPanel6.TabIndex = 9;
            // 
            // lb_Cam2_Result
            // 
            this.lb_Cam2_Result.AutoSize = true;
            this.lb_Cam2_Result.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam2_Result.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb_Cam2_Result.Location = new System.Drawing.Point(128, 1);
            this.lb_Cam2_Result.Name = "lb_Cam2_Result";
            this.lb_Cam2_Result.Size = new System.Drawing.Size(303, 65);
            this.lb_Cam2_Result.TabIndex = 1;
            this.lb_Cam2_Result.Text = "Result";
            this.lb_Cam2_Result.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_Cam2Stats
            // 
            this.lb_Cam2Stats.AutoSize = true;
            this.lb_Cam2Stats.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam2Stats.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb_Cam2Stats.Location = new System.Drawing.Point(4, 1);
            this.lb_Cam2Stats.Name = "lb_Cam2Stats";
            this.lb_Cam2Stats.Size = new System.Drawing.Size(117, 65);
            this.lb_Cam2Stats.TabIndex = 0;
            this.lb_Cam2Stats.Tag = "2";
            this.lb_Cam2Stats.Text = "CAM 2";
            this.lb_Cam2Stats.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_Cam2_InsTime
            // 
            this.lb_Cam2_InsTime.AutoSize = true;
            this.lb_Cam2_InsTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam2_InsTime.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb_Cam2_InsTime.Location = new System.Drawing.Point(438, 1);
            this.lb_Cam2_InsTime.Name = "lb_Cam2_InsTime";
            this.lb_Cam2_InsTime.Size = new System.Drawing.Size(181, 65);
            this.lb_Cam2_InsTime.TabIndex = 2;
            this.lb_Cam2_InsTime.Text = "0 msec";
            this.lb_Cam2_InsTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Controls.Add(this.cdyDisplay, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel10, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(4, 4);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 87F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(631, 565);
            this.tableLayoutPanel4.TabIndex = 13;
            // 
            // cdyDisplay
            // 
            this.cdyDisplay.ColorMapLowerClipColor = System.Drawing.Color.Black;
            this.cdyDisplay.ColorMapLowerRoiLimit = 0D;
            this.cdyDisplay.ColorMapPredefined = Cognex.VisionPro.Display.CogDisplayColorMapPredefinedConstants.None;
            this.cdyDisplay.ColorMapUpperClipColor = System.Drawing.Color.Black;
            this.cdyDisplay.ColorMapUpperRoiLimit = 1D;
            this.cdyDisplay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cdyDisplay.DoubleTapZoomCycleLength = 2;
            this.cdyDisplay.DoubleTapZoomSensitivity = 2.5D;
            this.cdyDisplay.Location = new System.Drawing.Point(4, 78);
            this.cdyDisplay.MouseWheelMode = Cognex.VisionPro.Display.CogDisplayMouseWheelModeConstants.Zoom1;
            this.cdyDisplay.MouseWheelSensitivity = 1D;
            this.cdyDisplay.Name = "cdyDisplay";
            this.cdyDisplay.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("cdyDisplay.OcxState")));
            this.cdyDisplay.Size = new System.Drawing.Size(623, 483);
            this.cdyDisplay.TabIndex = 8;
            // 
            // tableLayoutPanel10
            // 
            this.tableLayoutPanel10.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel10.ColumnCount = 3;
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel10.Controls.Add(this.lb_Cam1Stats, 0, 0);
            this.tableLayoutPanel10.Controls.Add(this.lb_Cam1_Result, 1, 0);
            this.tableLayoutPanel10.Controls.Add(this.lb_Cam1_InsTime, 2, 0);
            this.tableLayoutPanel10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel10.Location = new System.Drawing.Point(4, 4);
            this.tableLayoutPanel10.Name = "tableLayoutPanel10";
            this.tableLayoutPanel10.RowCount = 1;
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel10.Size = new System.Drawing.Size(623, 67);
            this.tableLayoutPanel10.TabIndex = 9;
            // 
            // lb_Cam1Stats
            // 
            this.lb_Cam1Stats.AutoSize = true;
            this.lb_Cam1Stats.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1Stats.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb_Cam1Stats.Location = new System.Drawing.Point(4, 1);
            this.lb_Cam1Stats.Name = "lb_Cam1Stats";
            this.lb_Cam1Stats.Size = new System.Drawing.Size(117, 65);
            this.lb_Cam1Stats.TabIndex = 0;
            this.lb_Cam1Stats.Tag = "1";
            this.lb_Cam1Stats.Text = "CAM 1";
            this.lb_Cam1Stats.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_Cam1_Result
            // 
            this.lb_Cam1_Result.AutoSize = true;
            this.lb_Cam1_Result.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1_Result.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb_Cam1_Result.Location = new System.Drawing.Point(128, 1);
            this.lb_Cam1_Result.Name = "lb_Cam1_Result";
            this.lb_Cam1_Result.Size = new System.Drawing.Size(303, 65);
            this.lb_Cam1_Result.TabIndex = 1;
            this.lb_Cam1_Result.Text = "Result";
            this.lb_Cam1_Result.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_Cam1_InsTime
            // 
            this.lb_Cam1_InsTime.AutoSize = true;
            this.lb_Cam1_InsTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1_InsTime.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb_Cam1_InsTime.Location = new System.Drawing.Point(438, 1);
            this.lb_Cam1_InsTime.Name = "lb_Cam1_InsTime";
            this.lb_Cam1_InsTime.Size = new System.Drawing.Size(181, 65);
            this.lb_Cam1_InsTime.TabIndex = 3;
            this.lb_Cam1_InsTime.Text = "0 msec";
            this.lb_Cam1_InsTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tlpUnder
            // 
            this.tlpUnder.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tlpUnder.ColumnCount = 13;
            this.tlpUnder.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.280139F));
            this.tlpUnder.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.280139F));
            this.tlpUnder.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.280139F));
            this.tlpUnder.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.280139F));
            this.tlpUnder.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.959229F));
            this.tlpUnder.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.280139F));
            this.tlpUnder.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.959229F));
            this.tlpUnder.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.280139F));
            this.tlpUnder.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.280139F));
            this.tlpUnder.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.280139F));
            this.tlpUnder.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.280139F));
            this.tlpUnder.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.280139F));
            this.tlpUnder.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.280139F));
            this.tlpUnder.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpUnder.Controls.Add(this.btn_SystemSetup, 12, 0);
            this.tlpUnder.Controls.Add(this.btn_ToolSetUp, 4, 0);
            this.tlpUnder.Controls.Add(this.btn_Model, 9, 0);
            this.tlpUnder.Controls.Add(this.btn_CamSet, 8, 0);
            this.tlpUnder.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tlpUnder.Location = new System.Drawing.Point(0, 1061);
            this.tlpUnder.Name = "tlpUnder";
            this.tlpUnder.RowCount = 1;
            this.tlpUnder.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpUnder.Size = new System.Drawing.Size(2176, 86);
            this.tlpUnder.TabIndex = 44;
            // 
            // btn_SystemSetup
            // 
            this.btn_SystemSetup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_SystemSetup.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_SystemSetup.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_SystemSetup.Location = new System.Drawing.Point(2016, 4);
            this.btn_SystemSetup.Name = "btn_SystemSetup";
            this.btn_SystemSetup.Size = new System.Drawing.Size(156, 78);
            this.btn_SystemSetup.TabIndex = 0;
            this.btn_SystemSetup.Text = "System Setting";
            this.btn_SystemSetup.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_SystemSetup.UseVisualStyleBackColor = true;
            // 
            // btn_ToolSetUp
            // 
            this.btn_ToolSetUp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_ToolSetUp.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_ToolSetUp.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_ToolSetUp.Location = new System.Drawing.Point(636, 4);
            this.btn_ToolSetUp.Name = "btn_ToolSetUp";
            this.btn_ToolSetUp.Size = new System.Drawing.Size(209, 78);
            this.btn_ToolSetUp.TabIndex = 0;
            this.btn_ToolSetUp.Tag = "Front";
            this.btn_ToolSetUp.Text = "Tool Setting";
            this.btn_ToolSetUp.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_ToolSetUp.UseVisualStyleBackColor = true;
            // 
            // btn_Model
            // 
            this.btn_Model.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Model.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_Model.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Model.Location = new System.Drawing.Point(1542, 4);
            this.btn_Model.Name = "btn_Model";
            this.btn_Model.Size = new System.Drawing.Size(151, 78);
            this.btn_Model.TabIndex = 2;
            this.btn_Model.Tag = "";
            this.btn_Model.Text = "Model";
            this.btn_Model.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Model.UseVisualStyleBackColor = true;
            // 
            // btn_CamSet
            // 
            this.btn_CamSet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_CamSet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_CamSet.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_CamSet.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_CamSet.Location = new System.Drawing.Point(1384, 4);
            this.btn_CamSet.Name = "btn_CamSet";
            this.btn_CamSet.Size = new System.Drawing.Size(151, 78);
            this.btn_CamSet.TabIndex = 51;
            this.btn_CamSet.Tag = "";
            this.btn_CamSet.Text = "Camera Setting";
            this.btn_CamSet.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_CamSet.UseVisualStyleBackColor = true;
            // 
            // formMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(2176, 1147);
            this.Controls.Add(this.tlpUnder);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.logControl1);
            this.Controls.Add(this.tlpTopSide);
            this.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "formMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HEATSINK VISION (Main)";
            this.tlpTopSide.ResumeLayout(false);
            this.tlpTopSide.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cdyDisplay3)).EndInit();
            this.tableLayoutPanel13.ResumeLayout(false);
            this.tableLayoutPanel13.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cdyDisplay2)).EndInit();
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cdyDisplay)).EndInit();
            this.tableLayoutPanel10.ResumeLayout(false);
            this.tableLayoutPanel10.PerformLayout();
            this.tlpUnder.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpTopSide;
        private System.Windows.Forms.Label lb_Mode;
        private System.Windows.Forms.Label lb_CurruntModelName;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lb_Time;
        private System.Windows.Forms.Label lb_Ver;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Button btn_Stop;
        private System.Windows.Forms.Button btn_Status;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb_PLCStats;
        private KimLib.LogControl logControl1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel8;
        internal Cognex.VisionPro.Display.CogDisplay cdyDisplay3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel13;
        private System.Windows.Forms.Label lb_Cam3_Result;
        private System.Windows.Forms.Label lb_Cam3Stats;
        private System.Windows.Forms.Label lb_Cam3_InsTime;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        internal Cognex.VisionPro.Display.CogDisplay cdyDisplay2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.Label lb_Cam2_Result;
        private System.Windows.Forms.Label lb_Cam2Stats;
        private System.Windows.Forms.Label lb_Cam2_InsTime;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        internal Cognex.VisionPro.Display.CogDisplay cdyDisplay;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel10;
        private System.Windows.Forms.Label lb_Cam1Stats;
        private System.Windows.Forms.Label lb_Cam1_Result;
        private System.Windows.Forms.Label lb_Cam1_InsTime;
        private System.Windows.Forms.TableLayoutPanel tlpUnder;
        private System.Windows.Forms.Button btn_SystemSetup;
        private System.Windows.Forms.Button btn_ToolSetUp;
        private System.Windows.Forms.Button btn_Model;
        private System.Windows.Forms.Button btn_CamSet;
    }
}

