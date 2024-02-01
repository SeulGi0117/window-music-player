namespace WindowsFormsApp1
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges4 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Utilities.BunifuPages.BunifuAnimatorNS.Animation animation1 = new Utilities.BunifuPages.BunifuAnimatorNS.Animation();
            this.pnlSideBar = new System.Windows.Forms.Panel();
            this.btnLyrics = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.indicator = new Bunifu.UI.WinForms.BunifuShapes();
            this.btnSidebar = new Bunifu.UI.WinForms.BunifuShapes();
            this.btnPlaylists = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnExplore = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnPlaying = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.player = new AxWMPLib.AxWindowsMediaPlayer();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.btnClose = new Bunifu.UI.WinForms.BunifuImageButton();
            this.lblHeader = new System.Windows.Forms.Label();
            this.bunifuFormDock1 = new Bunifu.UI.WinForms.BunifuFormDock();
            this.bunifuPages1 = new Bunifu.UI.WinForms.BunifuPages();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.Artist = new System.Windows.Forms.Label();
            this.Album = new System.Windows.Forms.Label();
            this.SongTitle = new System.Windows.Forms.Label();
            this.pic_art = new System.Windows.Forms.PictureBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.track_list = new System.Windows.Forms.ListBox();
            this.btn_open = new System.Windows.Forms.Button();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.lst_m2playlist = new System.Windows.Forms.ListBox();
            this.btn_music2 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.lst_m1playlist = new System.Windows.Forms.ListBox();
            this.btn_music1 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.Artist2 = new System.Windows.Forms.Label();
            this.SongTitle2 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnMaxVol = new Bunifu.UI.WinForms.BunifuImageButton();
            this.btnMute = new Bunifu.UI.WinForms.BunifuImageButton();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.repeat_once = new System.Windows.Forms.CheckBox();
            this.repeat = new System.Windows.Forms.CheckBox();
            this.shuffle = new System.Windows.Forms.CheckBox();
            this.progressbar = new Bunifu.UI.WinForms.BunifuProgressBar();
            this.lbl_track_start = new System.Windows.Forms.Label();
            this.pro_bar = new System.Windows.Forms.ProgressBar();
            this.btn_pause = new Bunifu.UI.WinForms.BunifuImageButton();
            this.p_bar = new System.Windows.Forms.ProgressBar();
            this.lbl_track_end = new System.Windows.Forms.Label();
            this.volume = new Bunifu.UI.WinForms.BunifuHSlider();
            this.btn_next = new Bunifu.UI.WinForms.BunifuImageButton();
            this.btn_Stop = new Bunifu.UI.WinForms.BunifuImageButton();
            this.btn_preview = new Bunifu.UI.WinForms.BunifuImageButton();
            this.btn_play = new Bunifu.UI.WinForms.BunifuImageButton();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.bunifuToolTip1 = new Bunifu.UI.WinForms.BunifuToolTip(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.pnlSideBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            this.pnlHeader.SuspendLayout();
            this.bunifuPages1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_art)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlSideBar
            // 
            this.pnlSideBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(240)))), ((int)(((byte)(244)))));
            this.pnlSideBar.Controls.Add(this.btnLyrics);
            this.pnlSideBar.Controls.Add(this.pictureBox4);
            this.pnlSideBar.Controls.Add(this.label2);
            this.pnlSideBar.Controls.Add(this.label1);
            this.pnlSideBar.Controls.Add(this.indicator);
            this.pnlSideBar.Controls.Add(this.btnSidebar);
            this.pnlSideBar.Controls.Add(this.btnPlaylists);
            this.pnlSideBar.Controls.Add(this.btnExplore);
            this.pnlSideBar.Controls.Add(this.btnPlaying);
            this.pnlSideBar.Controls.Add(this.player);
            this.pnlSideBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSideBar.Location = new System.Drawing.Point(0, 0);
            this.pnlSideBar.Name = "pnlSideBar";
            this.pnlSideBar.Size = new System.Drawing.Size(196, 600);
            this.pnlSideBar.TabIndex = 0;
            this.bunifuToolTip1.SetToolTip(this.pnlSideBar, "");
            this.bunifuToolTip1.SetToolTipIcon(this.pnlSideBar, null);
            this.bunifuToolTip1.SetToolTipTitle(this.pnlSideBar, "");
            // 
            // btnLyrics
            // 
            this.btnLyrics.AllowAnimations = true;
            this.btnLyrics.AllowMouseEffects = true;
            this.btnLyrics.AllowToggling = true;
            this.btnLyrics.AnimationSpeed = 200;
            this.btnLyrics.AutoGenerateColors = false;
            this.btnLyrics.AutoRoundBorders = false;
            this.btnLyrics.AutoSizeLeftIcon = true;
            this.btnLyrics.AutoSizeRightIcon = true;
            this.btnLyrics.BackColor = System.Drawing.Color.Transparent;
            this.btnLyrics.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.btnLyrics.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLyrics.BackgroundImage")));
            this.btnLyrics.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnLyrics.ButtonText = "Lyrics";
            this.btnLyrics.ButtonTextMarginLeft = 0;
            this.btnLyrics.ColorContrastOnClick = 45;
            this.btnLyrics.ColorContrastOnHover = 45;
            this.btnLyrics.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btnLyrics.CustomizableEdges = borderEdges1;
            this.btnLyrics.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnLyrics.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnLyrics.DisabledFillColor = System.Drawing.Color.Empty;
            this.btnLyrics.DisabledForecolor = System.Drawing.Color.Empty;
            this.btnLyrics.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnLyrics.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLyrics.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(107)))), ((int)(((byte)(121)))));
            this.btnLyrics.IconLeft = null;
            this.btnLyrics.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLyrics.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnLyrics.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnLyrics.IconMarginLeft = 11;
            this.btnLyrics.IconPadding = 10;
            this.btnLyrics.IconRight = null;
            this.btnLyrics.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLyrics.IconRightCursor = System.Windows.Forms.Cursors.Arrow;
            this.btnLyrics.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnLyrics.IconSize = 25;
            this.btnLyrics.IdleBorderColor = System.Drawing.Color.Empty;
            this.btnLyrics.IdleBorderRadius = 0;
            this.btnLyrics.IdleBorderThickness = 0;
            this.btnLyrics.IdleFillColor = System.Drawing.Color.Empty;
            this.btnLyrics.IdleIconLeftImage = null;
            this.btnLyrics.IdleIconRightImage = null;
            this.btnLyrics.IndicateFocus = true;
            this.btnLyrics.Location = new System.Drawing.Point(73, 393);
            this.btnLyrics.Name = "btnLyrics";
            this.btnLyrics.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnLyrics.OnDisabledState.BorderRadius = 1;
            this.btnLyrics.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnLyrics.OnDisabledState.BorderThickness = 1;
            this.btnLyrics.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnLyrics.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnLyrics.OnDisabledState.IconLeftImage = null;
            this.btnLyrics.OnDisabledState.IconRightImage = null;
            this.btnLyrics.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(240)))), ((int)(((byte)(244)))));
            this.btnLyrics.onHoverState.BorderRadius = 1;
            this.btnLyrics.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnLyrics.onHoverState.BorderThickness = 1;
            this.btnLyrics.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(240)))), ((int)(((byte)(244)))));
            this.btnLyrics.onHoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(33)))), ((int)(((byte)(53)))));
            this.btnLyrics.onHoverState.IconLeftImage = null;
            this.btnLyrics.onHoverState.IconRightImage = null;
            this.btnLyrics.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(240)))), ((int)(((byte)(244)))));
            this.btnLyrics.OnIdleState.BorderRadius = 1;
            this.btnLyrics.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnLyrics.OnIdleState.BorderThickness = 1;
            this.btnLyrics.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(240)))), ((int)(((byte)(244)))));
            this.btnLyrics.OnIdleState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(107)))), ((int)(((byte)(121)))));
            this.btnLyrics.OnIdleState.IconLeftImage = null;
            this.btnLyrics.OnIdleState.IconRightImage = null;
            this.btnLyrics.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(240)))), ((int)(((byte)(244)))));
            this.btnLyrics.OnPressedState.BorderRadius = 1;
            this.btnLyrics.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnLyrics.OnPressedState.BorderThickness = 1;
            this.btnLyrics.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(240)))), ((int)(((byte)(244)))));
            this.btnLyrics.OnPressedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(87)))), ((int)(((byte)(103)))));
            this.btnLyrics.OnPressedState.IconLeftImage = null;
            this.btnLyrics.OnPressedState.IconRightImage = null;
            this.btnLyrics.Size = new System.Drawing.Size(104, 29);
            this.btnLyrics.TabIndex = 9;
            this.btnLyrics.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLyrics.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnLyrics.TextMarginLeft = 0;
            this.btnLyrics.TextPadding = new System.Windows.Forms.Padding(0);
            this.bunifuToolTip1.SetToolTip(this.btnLyrics, "");
            this.bunifuToolTip1.SetToolTipIcon(this.btnLyrics, null);
            this.bunifuToolTip1.SetToolTipTitle(this.btnLyrics, "");
            this.btnLyrics.UseDefaultRadiusAndThickness = true;
            this.btnLyrics.Click += new System.EventHandler(this.btnLyrics_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(59, 48);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(62, 59);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 8;
            this.pictureBox4.TabStop = false;
            this.bunifuToolTip1.SetToolTip(this.pictureBox4, "");
            this.bunifuToolTip1.SetToolTipIcon(this.pictureBox4, null);
            this.bunifuToolTip1.SetToolTipTitle(this.pictureBox4, "");
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.SlateGray;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(49, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 23);
            this.label2.TabIndex = 7;
            this.label2.Text = "Premium";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuToolTip1.SetToolTip(this.label2, "");
            this.bunifuToolTip1.SetToolTipIcon(this.label2, null);
            this.bunifuToolTip1.SetToolTipTitle(this.label2, "");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(33)))), ((int)(((byte)(53)))));
            this.label1.Location = new System.Drawing.Point(50, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 21);
            this.label1.TabIndex = 6;
            this.label1.Text = "GiSookSa";
            this.bunifuToolTip1.SetToolTip(this.label1, "");
            this.bunifuToolTip1.SetToolTipIcon(this.label1, null);
            this.bunifuToolTip1.SetToolTipTitle(this.label1, "");
            // 
            // indicator
            // 
            this.indicator.Angle = 0F;
            this.indicator.BackColor = System.Drawing.Color.Transparent;
            this.indicator.BorderColor = System.Drawing.Color.DodgerBlue;
            this.indicator.BorderThickness = 3;
            this.indicator.FillColor = System.Drawing.Color.Transparent;
            this.indicator.FillShape = true;
            this.indicator.Location = new System.Drawing.Point(39, 217);
            this.indicator.Name = "indicator";
            this.indicator.Shape = Bunifu.UI.WinForms.BunifuShapes.Shapes.Circle;
            this.indicator.Sides = 5;
            this.indicator.Size = new System.Drawing.Size(13, 13);
            this.indicator.TabIndex = 2;
            this.indicator.Text = "bunifuShapes1";
            this.bunifuToolTip1.SetToolTip(this.indicator, "");
            this.bunifuToolTip1.SetToolTipIcon(this.indicator, null);
            this.bunifuToolTip1.SetToolTipTitle(this.indicator, "");
            // 
            // btnSidebar
            // 
            this.btnSidebar.Angle = 90F;
            this.btnSidebar.BackColor = System.Drawing.Color.Transparent;
            this.btnSidebar.BorderColor = System.Drawing.Color.Silver;
            this.btnSidebar.BorderThickness = 2;
            this.btnSidebar.FillColor = System.Drawing.Color.Transparent;
            this.btnSidebar.FillShape = true;
            this.btnSidebar.Location = new System.Drawing.Point(24, 217);
            this.btnSidebar.Name = "btnSidebar";
            this.btnSidebar.Shape = Bunifu.UI.WinForms.BunifuShapes.Shapes.Line;
            this.btnSidebar.Sides = 5;
            this.btnSidebar.Size = new System.Drawing.Size(43, 190);
            this.btnSidebar.TabIndex = 2;
            this.btnSidebar.Text = "bunifuShapes1";
            this.bunifuToolTip1.SetToolTip(this.btnSidebar, "");
            this.bunifuToolTip1.SetToolTipIcon(this.btnSidebar, null);
            this.bunifuToolTip1.SetToolTipTitle(this.btnSidebar, "");
            // 
            // btnPlaylists
            // 
            this.btnPlaylists.AllowAnimations = true;
            this.btnPlaylists.AllowMouseEffects = true;
            this.btnPlaylists.AllowToggling = true;
            this.btnPlaylists.AnimationSpeed = 200;
            this.btnPlaylists.AutoGenerateColors = false;
            this.btnPlaylists.AutoRoundBorders = false;
            this.btnPlaylists.AutoSizeLeftIcon = true;
            this.btnPlaylists.AutoSizeRightIcon = true;
            this.btnPlaylists.BackColor = System.Drawing.Color.Transparent;
            this.btnPlaylists.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.btnPlaylists.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPlaylists.BackgroundImage")));
            this.btnPlaylists.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnPlaylists.ButtonText = "Playlists";
            this.btnPlaylists.ButtonTextMarginLeft = 0;
            this.btnPlaylists.ColorContrastOnClick = 45;
            this.btnPlaylists.ColorContrastOnHover = 45;
            this.btnPlaylists.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.btnPlaylists.CustomizableEdges = borderEdges2;
            this.btnPlaylists.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnPlaylists.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnPlaylists.DisabledFillColor = System.Drawing.Color.Empty;
            this.btnPlaylists.DisabledForecolor = System.Drawing.Color.Empty;
            this.btnPlaylists.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnPlaylists.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlaylists.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(107)))), ((int)(((byte)(121)))));
            this.btnPlaylists.IconLeft = null;
            this.btnPlaylists.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPlaylists.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnPlaylists.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnPlaylists.IconMarginLeft = 11;
            this.btnPlaylists.IconPadding = 10;
            this.btnPlaylists.IconRight = null;
            this.btnPlaylists.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPlaylists.IconRightCursor = System.Windows.Forms.Cursors.Arrow;
            this.btnPlaylists.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnPlaylists.IconSize = 25;
            this.btnPlaylists.IdleBorderColor = System.Drawing.Color.Empty;
            this.btnPlaylists.IdleBorderRadius = 0;
            this.btnPlaylists.IdleBorderThickness = 0;
            this.btnPlaylists.IdleFillColor = System.Drawing.Color.Empty;
            this.btnPlaylists.IdleIconLeftImage = null;
            this.btnPlaylists.IdleIconRightImage = null;
            this.btnPlaylists.IndicateFocus = true;
            this.btnPlaylists.Location = new System.Drawing.Point(73, 329);
            this.btnPlaylists.Name = "btnPlaylists";
            this.btnPlaylists.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnPlaylists.OnDisabledState.BorderRadius = 1;
            this.btnPlaylists.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnPlaylists.OnDisabledState.BorderThickness = 1;
            this.btnPlaylists.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnPlaylists.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnPlaylists.OnDisabledState.IconLeftImage = null;
            this.btnPlaylists.OnDisabledState.IconRightImage = null;
            this.btnPlaylists.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(240)))), ((int)(((byte)(244)))));
            this.btnPlaylists.onHoverState.BorderRadius = 1;
            this.btnPlaylists.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnPlaylists.onHoverState.BorderThickness = 1;
            this.btnPlaylists.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(240)))), ((int)(((byte)(244)))));
            this.btnPlaylists.onHoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(33)))), ((int)(((byte)(53)))));
            this.btnPlaylists.onHoverState.IconLeftImage = null;
            this.btnPlaylists.onHoverState.IconRightImage = null;
            this.btnPlaylists.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(240)))), ((int)(((byte)(244)))));
            this.btnPlaylists.OnIdleState.BorderRadius = 1;
            this.btnPlaylists.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnPlaylists.OnIdleState.BorderThickness = 1;
            this.btnPlaylists.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(240)))), ((int)(((byte)(244)))));
            this.btnPlaylists.OnIdleState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(107)))), ((int)(((byte)(121)))));
            this.btnPlaylists.OnIdleState.IconLeftImage = null;
            this.btnPlaylists.OnIdleState.IconRightImage = null;
            this.btnPlaylists.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(240)))), ((int)(((byte)(244)))));
            this.btnPlaylists.OnPressedState.BorderRadius = 1;
            this.btnPlaylists.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnPlaylists.OnPressedState.BorderThickness = 1;
            this.btnPlaylists.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(240)))), ((int)(((byte)(244)))));
            this.btnPlaylists.OnPressedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(87)))), ((int)(((byte)(103)))));
            this.btnPlaylists.OnPressedState.IconLeftImage = null;
            this.btnPlaylists.OnPressedState.IconRightImage = null;
            this.btnPlaylists.Size = new System.Drawing.Size(104, 29);
            this.btnPlaylists.TabIndex = 5;
            this.btnPlaylists.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPlaylists.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnPlaylists.TextMarginLeft = 0;
            this.btnPlaylists.TextPadding = new System.Windows.Forms.Padding(0);
            this.bunifuToolTip1.SetToolTip(this.btnPlaylists, "");
            this.bunifuToolTip1.SetToolTipIcon(this.btnPlaylists, null);
            this.bunifuToolTip1.SetToolTipTitle(this.btnPlaylists, "");
            this.btnPlaylists.UseDefaultRadiusAndThickness = true;
            this.btnPlaylists.Click += new System.EventHandler(this.btnPlaylists_Click);
            // 
            // btnExplore
            // 
            this.btnExplore.AllowAnimations = true;
            this.btnExplore.AllowMouseEffects = true;
            this.btnExplore.AllowToggling = true;
            this.btnExplore.AnimationSpeed = 200;
            this.btnExplore.AutoGenerateColors = false;
            this.btnExplore.AutoRoundBorders = false;
            this.btnExplore.AutoSizeLeftIcon = true;
            this.btnExplore.AutoSizeRightIcon = true;
            this.btnExplore.BackColor = System.Drawing.Color.Transparent;
            this.btnExplore.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.btnExplore.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExplore.BackgroundImage")));
            this.btnExplore.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnExplore.ButtonText = "Explore";
            this.btnExplore.ButtonTextMarginLeft = 0;
            this.btnExplore.ColorContrastOnClick = 45;
            this.btnExplore.ColorContrastOnHover = 45;
            this.btnExplore.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges3.BottomLeft = true;
            borderEdges3.BottomRight = true;
            borderEdges3.TopLeft = true;
            borderEdges3.TopRight = true;
            this.btnExplore.CustomizableEdges = borderEdges3;
            this.btnExplore.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnExplore.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnExplore.DisabledFillColor = System.Drawing.Color.Empty;
            this.btnExplore.DisabledForecolor = System.Drawing.Color.Empty;
            this.btnExplore.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnExplore.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExplore.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(107)))), ((int)(((byte)(121)))));
            this.btnExplore.IconLeft = null;
            this.btnExplore.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExplore.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnExplore.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnExplore.IconMarginLeft = 11;
            this.btnExplore.IconPadding = 10;
            this.btnExplore.IconRight = null;
            this.btnExplore.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExplore.IconRightCursor = System.Windows.Forms.Cursors.Arrow;
            this.btnExplore.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnExplore.IconSize = 25;
            this.btnExplore.IdleBorderColor = System.Drawing.Color.Empty;
            this.btnExplore.IdleBorderRadius = 0;
            this.btnExplore.IdleBorderThickness = 0;
            this.btnExplore.IdleFillColor = System.Drawing.Color.Empty;
            this.btnExplore.IdleIconLeftImage = null;
            this.btnExplore.IdleIconRightImage = null;
            this.btnExplore.IndicateFocus = true;
            this.btnExplore.Location = new System.Drawing.Point(73, 265);
            this.btnExplore.Name = "btnExplore";
            this.btnExplore.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnExplore.OnDisabledState.BorderRadius = 1;
            this.btnExplore.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnExplore.OnDisabledState.BorderThickness = 1;
            this.btnExplore.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnExplore.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnExplore.OnDisabledState.IconLeftImage = null;
            this.btnExplore.OnDisabledState.IconRightImage = null;
            this.btnExplore.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(240)))), ((int)(((byte)(244)))));
            this.btnExplore.onHoverState.BorderRadius = 1;
            this.btnExplore.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnExplore.onHoverState.BorderThickness = 1;
            this.btnExplore.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(240)))), ((int)(((byte)(244)))));
            this.btnExplore.onHoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(33)))), ((int)(((byte)(53)))));
            this.btnExplore.onHoverState.IconLeftImage = null;
            this.btnExplore.onHoverState.IconRightImage = null;
            this.btnExplore.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(240)))), ((int)(((byte)(244)))));
            this.btnExplore.OnIdleState.BorderRadius = 1;
            this.btnExplore.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnExplore.OnIdleState.BorderThickness = 1;
            this.btnExplore.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(240)))), ((int)(((byte)(244)))));
            this.btnExplore.OnIdleState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(107)))), ((int)(((byte)(121)))));
            this.btnExplore.OnIdleState.IconLeftImage = null;
            this.btnExplore.OnIdleState.IconRightImage = null;
            this.btnExplore.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(240)))), ((int)(((byte)(244)))));
            this.btnExplore.OnPressedState.BorderRadius = 1;
            this.btnExplore.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnExplore.OnPressedState.BorderThickness = 1;
            this.btnExplore.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(240)))), ((int)(((byte)(244)))));
            this.btnExplore.OnPressedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(87)))), ((int)(((byte)(103)))));
            this.btnExplore.OnPressedState.IconLeftImage = null;
            this.btnExplore.OnPressedState.IconRightImage = null;
            this.btnExplore.Size = new System.Drawing.Size(104, 29);
            this.btnExplore.TabIndex = 4;
            this.btnExplore.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExplore.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnExplore.TextMarginLeft = 0;
            this.btnExplore.TextPadding = new System.Windows.Forms.Padding(0);
            this.bunifuToolTip1.SetToolTip(this.btnExplore, "");
            this.bunifuToolTip1.SetToolTipIcon(this.btnExplore, null);
            this.bunifuToolTip1.SetToolTipTitle(this.btnExplore, "");
            this.btnExplore.UseDefaultRadiusAndThickness = true;
            this.btnExplore.Click += new System.EventHandler(this.btnExplore_Click);
            // 
            // btnPlaying
            // 
            this.btnPlaying.AllowAnimations = true;
            this.btnPlaying.AllowMouseEffects = true;
            this.btnPlaying.AllowToggling = true;
            this.btnPlaying.AnimationSpeed = 200;
            this.btnPlaying.AutoGenerateColors = false;
            this.btnPlaying.AutoRoundBorders = false;
            this.btnPlaying.AutoSizeLeftIcon = true;
            this.btnPlaying.AutoSizeRightIcon = true;
            this.btnPlaying.BackColor = System.Drawing.Color.Transparent;
            this.btnPlaying.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.btnPlaying.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPlaying.BackgroundImage")));
            this.btnPlaying.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnPlaying.ButtonText = "Now Playing...";
            this.btnPlaying.ButtonTextMarginLeft = 0;
            this.btnPlaying.ColorContrastOnClick = 45;
            this.btnPlaying.ColorContrastOnHover = 45;
            this.btnPlaying.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges4.BottomLeft = true;
            borderEdges4.BottomRight = true;
            borderEdges4.TopLeft = true;
            borderEdges4.TopRight = true;
            this.btnPlaying.CustomizableEdges = borderEdges4;
            this.btnPlaying.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnPlaying.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnPlaying.DisabledFillColor = System.Drawing.Color.Empty;
            this.btnPlaying.DisabledForecolor = System.Drawing.Color.Empty;
            this.btnPlaying.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnPlaying.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlaying.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(107)))), ((int)(((byte)(121)))));
            this.btnPlaying.IconLeft = null;
            this.btnPlaying.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPlaying.IconLeftCursor = System.Windows.Forms.Cursors.Hand;
            this.btnPlaying.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnPlaying.IconMarginLeft = 11;
            this.btnPlaying.IconPadding = 10;
            this.btnPlaying.IconRight = null;
            this.btnPlaying.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPlaying.IconRightCursor = System.Windows.Forms.Cursors.Arrow;
            this.btnPlaying.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnPlaying.IconSize = 25;
            this.btnPlaying.IdleBorderColor = System.Drawing.Color.Empty;
            this.btnPlaying.IdleBorderRadius = 0;
            this.btnPlaying.IdleBorderThickness = 0;
            this.btnPlaying.IdleFillColor = System.Drawing.Color.Empty;
            this.btnPlaying.IdleIconLeftImage = null;
            this.btnPlaying.IdleIconRightImage = null;
            this.btnPlaying.IndicateFocus = true;
            this.btnPlaying.Location = new System.Drawing.Point(73, 205);
            this.btnPlaying.Name = "btnPlaying";
            this.btnPlaying.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnPlaying.OnDisabledState.BorderRadius = 1;
            this.btnPlaying.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnPlaying.OnDisabledState.BorderThickness = 1;
            this.btnPlaying.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnPlaying.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnPlaying.OnDisabledState.IconLeftImage = null;
            this.btnPlaying.OnDisabledState.IconRightImage = null;
            this.btnPlaying.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(240)))), ((int)(((byte)(244)))));
            this.btnPlaying.onHoverState.BorderRadius = 1;
            this.btnPlaying.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnPlaying.onHoverState.BorderThickness = 1;
            this.btnPlaying.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(240)))), ((int)(((byte)(244)))));
            this.btnPlaying.onHoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(33)))), ((int)(((byte)(53)))));
            this.btnPlaying.onHoverState.IconLeftImage = null;
            this.btnPlaying.onHoverState.IconRightImage = null;
            this.btnPlaying.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(240)))), ((int)(((byte)(244)))));
            this.btnPlaying.OnIdleState.BorderRadius = 1;
            this.btnPlaying.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnPlaying.OnIdleState.BorderThickness = 1;
            this.btnPlaying.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(240)))), ((int)(((byte)(244)))));
            this.btnPlaying.OnIdleState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(107)))), ((int)(((byte)(121)))));
            this.btnPlaying.OnIdleState.IconLeftImage = null;
            this.btnPlaying.OnIdleState.IconRightImage = null;
            this.btnPlaying.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(240)))), ((int)(((byte)(244)))));
            this.btnPlaying.OnPressedState.BorderRadius = 1;
            this.btnPlaying.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnPlaying.OnPressedState.BorderThickness = 1;
            this.btnPlaying.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(240)))), ((int)(((byte)(244)))));
            this.btnPlaying.OnPressedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(87)))), ((int)(((byte)(103)))));
            this.btnPlaying.OnPressedState.IconLeftImage = null;
            this.btnPlaying.OnPressedState.IconRightImage = null;
            this.btnPlaying.Size = new System.Drawing.Size(111, 29);
            this.btnPlaying.TabIndex = 3;
            this.btnPlaying.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPlaying.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnPlaying.TextMarginLeft = 0;
            this.btnPlaying.TextPadding = new System.Windows.Forms.Padding(0);
            this.bunifuToolTip1.SetToolTip(this.btnPlaying, "");
            this.bunifuToolTip1.SetToolTipIcon(this.btnPlaying, null);
            this.bunifuToolTip1.SetToolTipTitle(this.btnPlaying, "");
            this.btnPlaying.UseDefaultRadiusAndThickness = true;
            this.btnPlaying.Click += new System.EventHandler(this.btnPlaying_Click);
            // 
            // player
            // 
            this.player.Enabled = true;
            this.player.Location = new System.Drawing.Point(116, 812);
            this.player.Name = "player";
            this.player.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("player.OcxState")));
            this.player.Size = new System.Drawing.Size(58, 55);
            this.player.TabIndex = 1;
            this.bunifuToolTip1.SetToolTip(this.player, "");
            this.bunifuToolTip1.SetToolTipIcon(this.player, null);
            this.bunifuToolTip1.SetToolTipTitle(this.player, "");
            this.player.Visible = false;
            this.player.PlayStateChange += new AxWMPLib._WMPOCXEvents_PlayStateChangeEventHandler(this.player_PlayStateChange);
            // 
            // pnlHeader
            // 
            this.pnlHeader.Controls.Add(this.btnClose);
            this.pnlHeader.Controls.Add(this.lblHeader);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(196, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(766, 47);
            this.pnlHeader.TabIndex = 1;
            this.bunifuToolTip1.SetToolTip(this.pnlHeader, "");
            this.bunifuToolTip1.SetToolTipIcon(this.pnlHeader, null);
            this.bunifuToolTip1.SetToolTipTitle(this.pnlHeader, "");
            // 
            // btnClose
            // 
            this.btnClose.ActiveImage = null;
            this.btnClose.AllowAnimations = true;
            this.btnClose.AllowBuffering = false;
            this.btnClose.AllowToggling = false;
            this.btnClose.AllowZooming = true;
            this.btnClose.AllowZoomingOnFocus = false;
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnClose.ErrorImage = ((System.Drawing.Image)(resources.GetObject("btnClose.ErrorImage")));
            this.btnClose.FadeWhenInactive = false;
            this.btnClose.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageActive = null;
            this.btnClose.ImageLocation = null;
            this.btnClose.ImageMargin = 20;
            this.btnClose.ImageSize = new System.Drawing.Size(15, 12);
            this.btnClose.ImageZoomSize = new System.Drawing.Size(35, 32);
            this.btnClose.InitialImage = ((System.Drawing.Image)(resources.GetObject("btnClose.InitialImage")));
            this.btnClose.Location = new System.Drawing.Point(723, 8);
            this.btnClose.Name = "btnClose";
            this.btnClose.Rotation = 0;
            this.btnClose.ShowActiveImage = true;
            this.btnClose.ShowCursorChanges = true;
            this.btnClose.ShowImageBorders = true;
            this.btnClose.ShowSizeMarkers = false;
            this.btnClose.Size = new System.Drawing.Size(35, 32);
            this.btnClose.TabIndex = 0;
            this.bunifuToolTip1.SetToolTip(this.btnClose, "");
            this.bunifuToolTip1.SetToolTipIcon(this.btnClose, null);
            this.btnClose.ToolTipText = "";
            this.bunifuToolTip1.SetToolTipTitle(this.btnClose, "");
            this.btnClose.WaitOnLoad = false;
            this.btnClose.Zoom = 20;
            this.btnClose.ZoomSpeed = 10;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblHeader
            // 
            this.lblHeader.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(33)))), ((int)(((byte)(53)))));
            this.lblHeader.Location = new System.Drawing.Point(17, 13);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(101, 21);
            this.lblHeader.TabIndex = 16;
            this.lblHeader.Text = "Music Player";
            this.lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuToolTip1.SetToolTip(this.lblHeader, "");
            this.bunifuToolTip1.SetToolTipIcon(this.lblHeader, null);
            this.bunifuToolTip1.SetToolTipTitle(this.lblHeader, "");
            // 
            // bunifuFormDock1
            // 
            this.bunifuFormDock1.AllowFormDragging = true;
            this.bunifuFormDock1.AllowFormDropShadow = true;
            this.bunifuFormDock1.AllowFormResizing = false;
            this.bunifuFormDock1.AllowHidingBottomRegion = true;
            this.bunifuFormDock1.AllowOpacityChangesWhileDragging = false;
            this.bunifuFormDock1.BorderOptions.BottomBorder.BorderColor = System.Drawing.Color.Silver;
            this.bunifuFormDock1.BorderOptions.BottomBorder.BorderThickness = 1;
            this.bunifuFormDock1.BorderOptions.BottomBorder.ShowBorder = true;
            this.bunifuFormDock1.BorderOptions.LeftBorder.BorderColor = System.Drawing.Color.Silver;
            this.bunifuFormDock1.BorderOptions.LeftBorder.BorderThickness = 1;
            this.bunifuFormDock1.BorderOptions.LeftBorder.ShowBorder = true;
            this.bunifuFormDock1.BorderOptions.RightBorder.BorderColor = System.Drawing.Color.Silver;
            this.bunifuFormDock1.BorderOptions.RightBorder.BorderThickness = 1;
            this.bunifuFormDock1.BorderOptions.RightBorder.ShowBorder = true;
            this.bunifuFormDock1.BorderOptions.TopBorder.BorderColor = System.Drawing.Color.Silver;
            this.bunifuFormDock1.BorderOptions.TopBorder.BorderThickness = 1;
            this.bunifuFormDock1.BorderOptions.TopBorder.ShowBorder = true;
            this.bunifuFormDock1.ContainerControl = this;
            this.bunifuFormDock1.DockingIndicatorsColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(248)))), ((int)(((byte)(250)))));
            this.bunifuFormDock1.DockingIndicatorsOpacity = 0.5D;
            this.bunifuFormDock1.DockingOptions.DockAll = true;
            this.bunifuFormDock1.DockingOptions.DockBottomLeft = true;
            this.bunifuFormDock1.DockingOptions.DockBottomRight = true;
            this.bunifuFormDock1.DockingOptions.DockFullScreen = true;
            this.bunifuFormDock1.DockingOptions.DockLeft = true;
            this.bunifuFormDock1.DockingOptions.DockRight = true;
            this.bunifuFormDock1.DockingOptions.DockTopLeft = true;
            this.bunifuFormDock1.DockingOptions.DockTopRight = true;
            this.bunifuFormDock1.FormDraggingOpacity = 0.9D;
            this.bunifuFormDock1.ParentForm = this;
            this.bunifuFormDock1.ShowCursorChanges = true;
            this.bunifuFormDock1.ShowDockingIndicators = false;
            this.bunifuFormDock1.TitleBarOptions.AllowFormDragging = true;
            this.bunifuFormDock1.TitleBarOptions.BunifuFormDock = this.bunifuFormDock1;
            this.bunifuFormDock1.TitleBarOptions.DoubleClickToExpandWindow = false;
            this.bunifuFormDock1.TitleBarOptions.TitleBarControl = this.pnlHeader;
            this.bunifuFormDock1.TitleBarOptions.UseBackColorOnDockingIndicators = true;
            // 
            // bunifuPages1
            // 
            this.bunifuPages1.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.bunifuPages1.AllowTransitions = false;
            this.bunifuPages1.Controls.Add(this.tabPage1);
            this.bunifuPages1.Controls.Add(this.tabPage2);
            this.bunifuPages1.Controls.Add(this.tabPage3);
            this.bunifuPages1.Controls.Add(this.tabPage4);
            this.bunifuPages1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuPages1.Location = new System.Drawing.Point(196, 47);
            this.bunifuPages1.Multiline = true;
            this.bunifuPages1.Name = "bunifuPages1";
            this.bunifuPages1.Page = this.tabPage2;
            this.bunifuPages1.PageIndex = 1;
            this.bunifuPages1.PageName = "tabPage2";
            this.bunifuPages1.PageTitle = "Explore";
            this.bunifuPages1.SelectedIndex = 0;
            this.bunifuPages1.Size = new System.Drawing.Size(766, 465);
            this.bunifuPages1.TabIndex = 2;
            this.bunifuToolTip1.SetToolTip(this.bunifuPages1, "");
            this.bunifuToolTip1.SetToolTipIcon(this.bunifuPages1, null);
            this.bunifuToolTip1.SetToolTipTitle(this.bunifuPages1, "");
            animation1.AnimateOnlyDifferences = false;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.bunifuPages1.Transition = animation1;
            this.bunifuPages1.TransitionType = Utilities.BunifuPages.BunifuAnimatorNS.AnimationType.Custom;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(248)))), ((int)(((byte)(250)))));
            this.tabPage1.Controls.Add(this.Artist);
            this.tabPage1.Controls.Add(this.Album);
            this.tabPage1.Controls.Add(this.SongTitle);
            this.tabPage1.Controls.Add(this.pic_art);
            this.tabPage1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(758, 439);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Playing";
            this.bunifuToolTip1.SetToolTip(this.tabPage1, "");
            this.bunifuToolTip1.SetToolTipIcon(this.tabPage1, null);
            this.bunifuToolTip1.SetToolTipTitle(this.tabPage1, "");
            // 
            // Artist
            // 
            this.Artist.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.Artist.AutoSize = true;
            this.Artist.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Artist.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(33)))), ((int)(((byte)(53)))));
            this.Artist.Location = new System.Drawing.Point(374, 257);
            this.Artist.Name = "Artist";
            this.Artist.Size = new System.Drawing.Size(61, 28);
            this.Artist.TabIndex = 20;
            this.Artist.Text = "Artist";
            this.Artist.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuToolTip1.SetToolTip(this.Artist, "");
            this.bunifuToolTip1.SetToolTipIcon(this.Artist, null);
            this.bunifuToolTip1.SetToolTipTitle(this.Artist, "");
            // 
            // Album
            // 
            this.Album.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.Album.AutoSize = true;
            this.Album.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Album.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(33)))), ((int)(((byte)(53)))));
            this.Album.Location = new System.Drawing.Point(374, 206);
            this.Album.Name = "Album";
            this.Album.Size = new System.Drawing.Size(72, 28);
            this.Album.TabIndex = 19;
            this.Album.Text = "Album";
            this.Album.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuToolTip1.SetToolTip(this.Album, "");
            this.bunifuToolTip1.SetToolTipIcon(this.Album, null);
            this.bunifuToolTip1.SetToolTipTitle(this.Album, "");
            // 
            // SongTitle
            // 
            this.SongTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.SongTitle.AutoSize = true;
            this.SongTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SongTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(33)))), ((int)(((byte)(53)))));
            this.SongTitle.Location = new System.Drawing.Point(374, 156);
            this.SongTitle.Name = "SongTitle";
            this.SongTitle.Size = new System.Drawing.Size(98, 28);
            this.SongTitle.TabIndex = 18;
            this.SongTitle.Text = "SongTitle";
            this.SongTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuToolTip1.SetToolTip(this.SongTitle, "");
            this.bunifuToolTip1.SetToolTipIcon(this.SongTitle, null);
            this.bunifuToolTip1.SetToolTipTitle(this.SongTitle, "");
            // 
            // pic_art
            // 
            this.pic_art.Image = ((System.Drawing.Image)(resources.GetObject("pic_art.Image")));
            this.pic_art.Location = new System.Drawing.Point(52, 116);
            this.pic_art.Name = "pic_art";
            this.pic_art.Size = new System.Drawing.Size(262, 240);
            this.pic_art.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_art.TabIndex = 17;
            this.pic_art.TabStop = false;
            this.bunifuToolTip1.SetToolTip(this.pic_art, "");
            this.bunifuToolTip1.SetToolTipIcon(this.pic_art, null);
            this.bunifuToolTip1.SetToolTipTitle(this.pic_art, "");
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(248)))), ((int)(((byte)(250)))));
            this.tabPage2.Controls.Add(this.track_list);
            this.tabPage2.Controls.Add(this.btn_open);
            this.tabPage2.Controls.Add(this.axWindowsMediaPlayer1);
            this.tabPage2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage2.Location = new System.Drawing.Point(4, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(758, 439);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Explore";
            this.bunifuToolTip1.SetToolTip(this.tabPage2, "");
            this.bunifuToolTip1.SetToolTipIcon(this.tabPage2, null);
            this.bunifuToolTip1.SetToolTipTitle(this.tabPage2, "");
            // 
            // track_list
            // 
            this.track_list.FormattingEnabled = true;
            this.track_list.ItemHeight = 15;
            this.track_list.Location = new System.Drawing.Point(18, 39);
            this.track_list.Name = "track_list";
            this.track_list.Size = new System.Drawing.Size(711, 424);
            this.track_list.TabIndex = 3;
            this.bunifuToolTip1.SetToolTip(this.track_list, "");
            this.bunifuToolTip1.SetToolTipIcon(this.track_list, null);
            this.bunifuToolTip1.SetToolTipTitle(this.track_list, "");
            this.track_list.SelectedIndexChanged += new System.EventHandler(this.track_list_SelectedIndexChanged);
            // 
            // btn_open
            // 
            this.btn_open.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_open.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_open.ForeColor = System.Drawing.Color.DarkBlue;
            this.btn_open.Location = new System.Drawing.Point(17, 3);
            this.btn_open.Name = "btn_open";
            this.btn_open.Size = new System.Drawing.Size(143, 35);
            this.btn_open.TabIndex = 1;
            this.btn_open.Text = "IMPORT";
            this.bunifuToolTip1.SetToolTip(this.btn_open, "");
            this.bunifuToolTip1.SetToolTipIcon(this.btn_open, null);
            this.bunifuToolTip1.SetToolTipTitle(this.btn_open, "");
            this.btn_open.UseVisualStyleBackColor = true;
            this.btn_open.Click += new System.EventHandler(this.btn_open_Click);
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(280, 214);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(234, 72);
            this.axWindowsMediaPlayer1.TabIndex = 2;
            this.bunifuToolTip1.SetToolTip(this.axWindowsMediaPlayer1, "");
            this.bunifuToolTip1.SetToolTipIcon(this.axWindowsMediaPlayer1, null);
            this.bunifuToolTip1.SetToolTipTitle(this.axWindowsMediaPlayer1, "");
            this.axWindowsMediaPlayer1.Visible = false;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(248)))), ((int)(((byte)(250)))));
            this.tabPage3.Controls.Add(this.lst_m2playlist);
            this.tabPage3.Controls.Add(this.btn_music2);
            this.tabPage3.Controls.Add(this.lst_m1playlist);
            this.tabPage3.Controls.Add(this.btn_music1);
            this.tabPage3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage3.Location = new System.Drawing.Point(4, 4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(758, 439);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Playlists";
            this.bunifuToolTip1.SetToolTip(this.tabPage3, "");
            this.bunifuToolTip1.SetToolTipIcon(this.tabPage3, null);
            this.bunifuToolTip1.SetToolTipTitle(this.tabPage3, "");
            // 
            // lst_m2playlist
            // 
            this.lst_m2playlist.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lst_m2playlist.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.lst_m2playlist.FormattingEnabled = true;
            this.lst_m2playlist.ItemHeight = 15;
            this.lst_m2playlist.Location = new System.Drawing.Point(51, 268);
            this.lst_m2playlist.Name = "lst_m2playlist";
            this.lst_m2playlist.Size = new System.Drawing.Size(645, 139);
            this.lst_m2playlist.TabIndex = 5;
            this.bunifuToolTip1.SetToolTip(this.lst_m2playlist, "");
            this.bunifuToolTip1.SetToolTipIcon(this.lst_m2playlist, null);
            this.bunifuToolTip1.SetToolTipTitle(this.lst_m2playlist, "");
            this.lst_m2playlist.SelectedIndexChanged += new System.EventHandler(this.lst_m2playlist_SelectedIndexChanged);
            // 
            // btn_music2
            // 
            this.btn_music2.ActiveBorderThickness = 1;
            this.btn_music2.ActiveCornerRadius = 20;
            this.btn_music2.ActiveFillColor = System.Drawing.Color.SlateGray;
            this.btn_music2.ActiveForecolor = System.Drawing.Color.White;
            this.btn_music2.ActiveLineColor = System.Drawing.Color.SlateGray;
            this.btn_music2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(248)))), ((int)(((byte)(250)))));
            this.btn_music2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_music2.BackgroundImage")));
            this.btn_music2.ButtonText = "music2";
            this.btn_music2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_music2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_music2.ForeColor = System.Drawing.Color.SlateGray;
            this.btn_music2.IdleBorderThickness = 1;
            this.btn_music2.IdleCornerRadius = 20;
            this.btn_music2.IdleFillColor = System.Drawing.Color.White;
            this.btn_music2.IdleForecolor = System.Drawing.Color.SlateGray;
            this.btn_music2.IdleLineColor = System.Drawing.Color.SlateGray;
            this.btn_music2.Location = new System.Drawing.Point(39, 223);
            this.btn_music2.Margin = new System.Windows.Forms.Padding(4);
            this.btn_music2.Name = "btn_music2";
            this.btn_music2.Size = new System.Drawing.Size(158, 33);
            this.btn_music2.TabIndex = 4;
            this.btn_music2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuToolTip1.SetToolTip(this.btn_music2, "");
            this.bunifuToolTip1.SetToolTipIcon(this.btn_music2, null);
            this.bunifuToolTip1.SetToolTipTitle(this.btn_music2, "");
            this.btn_music2.Click += new System.EventHandler(this.btn_music2_Click);
            // 
            // lst_m1playlist
            // 
            this.lst_m1playlist.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lst_m1playlist.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.lst_m1playlist.FormattingEnabled = true;
            this.lst_m1playlist.ItemHeight = 15;
            this.lst_m1playlist.Location = new System.Drawing.Point(51, 61);
            this.lst_m1playlist.Name = "lst_m1playlist";
            this.lst_m1playlist.Size = new System.Drawing.Size(645, 139);
            this.lst_m1playlist.TabIndex = 3;
            this.bunifuToolTip1.SetToolTip(this.lst_m1playlist, "");
            this.bunifuToolTip1.SetToolTipIcon(this.lst_m1playlist, null);
            this.bunifuToolTip1.SetToolTipTitle(this.lst_m1playlist, "");
            this.lst_m1playlist.SelectedIndexChanged += new System.EventHandler(this.lst_m1playlist_SelectedIndexChanged);
            // 
            // btn_music1
            // 
            this.btn_music1.ActiveBorderThickness = 1;
            this.btn_music1.ActiveCornerRadius = 20;
            this.btn_music1.ActiveFillColor = System.Drawing.Color.SlateGray;
            this.btn_music1.ActiveForecolor = System.Drawing.Color.White;
            this.btn_music1.ActiveLineColor = System.Drawing.Color.SlateGray;
            this.btn_music1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(248)))), ((int)(((byte)(250)))));
            this.btn_music1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_music1.BackgroundImage")));
            this.btn_music1.ButtonText = "music1";
            this.btn_music1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_music1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_music1.ForeColor = System.Drawing.Color.SlateGray;
            this.btn_music1.IdleBorderThickness = 1;
            this.btn_music1.IdleCornerRadius = 20;
            this.btn_music1.IdleFillColor = System.Drawing.Color.White;
            this.btn_music1.IdleForecolor = System.Drawing.Color.SlateGray;
            this.btn_music1.IdleLineColor = System.Drawing.Color.SlateGray;
            this.btn_music1.Location = new System.Drawing.Point(39, 17);
            this.btn_music1.Margin = new System.Windows.Forms.Padding(4);
            this.btn_music1.Name = "btn_music1";
            this.btn_music1.Size = new System.Drawing.Size(158, 33);
            this.btn_music1.TabIndex = 1;
            this.btn_music1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuToolTip1.SetToolTip(this.btn_music1, "");
            this.bunifuToolTip1.SetToolTipIcon(this.btn_music1, null);
            this.bunifuToolTip1.SetToolTipTitle(this.btn_music1, "");
            this.btn_music1.Click += new System.EventHandler(this.btn_music1_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.AutoScroll = true;
            this.tabPage4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(248)))), ((int)(((byte)(250)))));
            this.tabPage4.Controls.Add(this.Artist2);
            this.tabPage4.Controls.Add(this.SongTitle2);
            this.tabPage4.Controls.Add(this.richTextBox1);
            this.tabPage4.Controls.Add(this.pictureBox1);
            this.tabPage4.Cursor = System.Windows.Forms.Cursors.Default;
            this.tabPage4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage4.Location = new System.Drawing.Point(4, 4);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(758, 439);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Lyrics";
            this.bunifuToolTip1.SetToolTip(this.tabPage4, "");
            this.bunifuToolTip1.SetToolTipIcon(this.tabPage4, null);
            this.bunifuToolTip1.SetToolTipTitle(this.tabPage4, "");
            // 
            // Artist2
            // 
            this.Artist2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.Artist2.AutoSize = true;
            this.Artist2.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Artist2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(33)))), ((int)(((byte)(53)))));
            this.Artist2.Location = new System.Drawing.Point(230, 87);
            this.Artist2.Name = "Artist2";
            this.Artist2.Size = new System.Drawing.Size(60, 25);
            this.Artist2.TabIndex = 29;
            this.Artist2.Text = "Artist";
            this.Artist2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuToolTip1.SetToolTip(this.Artist2, "");
            this.bunifuToolTip1.SetToolTipIcon(this.Artist2, null);
            this.bunifuToolTip1.SetToolTipTitle(this.Artist2, "");
            // 
            // SongTitle2
            // 
            this.SongTitle2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.SongTitle2.AutoSize = true;
            this.SongTitle2.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SongTitle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(33)))), ((int)(((byte)(53)))));
            this.SongTitle2.Location = new System.Drawing.Point(230, 45);
            this.SongTitle2.Name = "SongTitle2";
            this.SongTitle2.Size = new System.Drawing.Size(97, 25);
            this.SongTitle2.TabIndex = 28;
            this.SongTitle2.Text = "Song Title";
            this.SongTitle2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuToolTip1.SetToolTip(this.SongTitle2, "");
            this.bunifuToolTip1.SetToolTipIcon(this.SongTitle2, null);
            this.bunifuToolTip1.SetToolTipTitle(this.SongTitle2, "");
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(248)))), ((int)(((byte)(250)))));
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.richTextBox1.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(235, 132);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(479, 277);
            this.richTextBox1.TabIndex = 27;
            this.richTextBox1.Text = "";
            this.bunifuToolTip1.SetToolTip(this.richTextBox1, "");
            this.bunifuToolTip1.SetToolTipIcon(this.richTextBox1, null);
            this.bunifuToolTip1.SetToolTipTitle(this.richTextBox1, "");
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(32, 45);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(164, 161);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            this.bunifuToolTip1.SetToolTip(this.pictureBox1, "");
            this.bunifuToolTip1.SetToolTipIcon(this.pictureBox1, null);
            this.bunifuToolTip1.SetToolTipTitle(this.pictureBox1, "");
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SlateGray;
            this.panel1.Controls.Add(this.btnMaxVol);
            this.panel1.Controls.Add(this.btnMute);
            this.panel1.Controls.Add(this.pictureBox6);
            this.panel1.Controls.Add(this.pictureBox5);
            this.panel1.Controls.Add(this.repeat_once);
            this.panel1.Controls.Add(this.repeat);
            this.panel1.Controls.Add(this.shuffle);
            this.panel1.Controls.Add(this.progressbar);
            this.panel1.Controls.Add(this.lbl_track_start);
            this.panel1.Controls.Add(this.pro_bar);
            this.panel1.Controls.Add(this.btn_pause);
            this.panel1.Controls.Add(this.p_bar);
            this.panel1.Controls.Add(this.lbl_track_end);
            this.panel1.Controls.Add(this.volume);
            this.panel1.Controls.Add(this.btn_next);
            this.panel1.Controls.Add(this.btn_Stop);
            this.panel1.Controls.Add(this.btn_preview);
            this.panel1.Controls.Add(this.btn_play);
            this.panel1.Controls.Add(this.pictureBox7);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(196, 512);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(766, 88);
            this.panel1.TabIndex = 3;
            this.bunifuToolTip1.SetToolTip(this.panel1, "");
            this.bunifuToolTip1.SetToolTipIcon(this.panel1, null);
            this.bunifuToolTip1.SetToolTipTitle(this.panel1, "");
            // 
            // btnMaxVol
            // 
            this.btnMaxVol.ActiveImage = null;
            this.btnMaxVol.AllowAnimations = true;
            this.btnMaxVol.AllowBuffering = false;
            this.btnMaxVol.AllowToggling = false;
            this.btnMaxVol.AllowZooming = true;
            this.btnMaxVol.AllowZoomingOnFocus = false;
            this.btnMaxVol.BackColor = System.Drawing.Color.Transparent;
            this.btnMaxVol.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnMaxVol.ErrorImage = ((System.Drawing.Image)(resources.GetObject("btnMaxVol.ErrorImage")));
            this.btnMaxVol.FadeWhenInactive = false;
            this.btnMaxVol.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.btnMaxVol.Image = ((System.Drawing.Image)(resources.GetObject("btnMaxVol.Image")));
            this.btnMaxVol.ImageActive = null;
            this.btnMaxVol.ImageLocation = null;
            this.btnMaxVol.ImageMargin = 10;
            this.btnMaxVol.ImageSize = new System.Drawing.Size(22, 19);
            this.btnMaxVol.ImageZoomSize = new System.Drawing.Size(32, 29);
            this.btnMaxVol.InitialImage = ((System.Drawing.Image)(resources.GetObject("btnMaxVol.InitialImage")));
            this.btnMaxVol.Location = new System.Drawing.Point(722, 29);
            this.btnMaxVol.Name = "btnMaxVol";
            this.btnMaxVol.Rotation = 0;
            this.btnMaxVol.ShowActiveImage = true;
            this.btnMaxVol.ShowCursorChanges = true;
            this.btnMaxVol.ShowImageBorders = true;
            this.btnMaxVol.ShowSizeMarkers = false;
            this.btnMaxVol.Size = new System.Drawing.Size(32, 29);
            this.btnMaxVol.TabIndex = 25;
            this.bunifuToolTip1.SetToolTip(this.btnMaxVol, "Max Vol");
            this.bunifuToolTip1.SetToolTipIcon(this.btnMaxVol, null);
            this.btnMaxVol.ToolTipText = "";
            this.bunifuToolTip1.SetToolTipTitle(this.btnMaxVol, "");
            this.btnMaxVol.WaitOnLoad = false;
            this.btnMaxVol.Zoom = 10;
            this.btnMaxVol.ZoomSpeed = 10;
            this.btnMaxVol.Click += new System.EventHandler(this.btnMaxVol_Click);
            // 
            // btnMute
            // 
            this.btnMute.ActiveImage = null;
            this.btnMute.AllowAnimations = true;
            this.btnMute.AllowBuffering = false;
            this.btnMute.AllowToggling = false;
            this.btnMute.AllowZooming = true;
            this.btnMute.AllowZoomingOnFocus = false;
            this.btnMute.BackColor = System.Drawing.Color.Transparent;
            this.btnMute.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnMute.ErrorImage = ((System.Drawing.Image)(resources.GetObject("btnMute.ErrorImage")));
            this.btnMute.FadeWhenInactive = false;
            this.btnMute.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.btnMute.Image = ((System.Drawing.Image)(resources.GetObject("btnMute.Image")));
            this.btnMute.ImageActive = null;
            this.btnMute.ImageLocation = null;
            this.btnMute.ImageMargin = 10;
            this.btnMute.ImageSize = new System.Drawing.Size(21, 18);
            this.btnMute.ImageZoomSize = new System.Drawing.Size(31, 28);
            this.btnMute.InitialImage = ((System.Drawing.Image)(resources.GetObject("btnMute.InitialImage")));
            this.btnMute.Location = new System.Drawing.Point(602, 29);
            this.btnMute.Name = "btnMute";
            this.btnMute.Rotation = 0;
            this.btnMute.ShowActiveImage = true;
            this.btnMute.ShowCursorChanges = true;
            this.btnMute.ShowImageBorders = true;
            this.btnMute.ShowSizeMarkers = false;
            this.btnMute.Size = new System.Drawing.Size(31, 28);
            this.btnMute.TabIndex = 18;
            this.bunifuToolTip1.SetToolTip(this.btnMute, "Mute");
            this.bunifuToolTip1.SetToolTipIcon(this.btnMute, null);
            this.btnMute.ToolTipText = "";
            this.bunifuToolTip1.SetToolTipTitle(this.btnMute, "");
            this.btnMute.WaitOnLoad = false;
            this.btnMute.Zoom = 10;
            this.btnMute.ZoomSpeed = 10;
            this.btnMute.Click += new System.EventHandler(this.btnMute_Click);
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(88, 59);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(24, 19);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 23;
            this.pictureBox6.TabStop = false;
            this.bunifuToolTip1.SetToolTip(this.pictureBox6, "repeat");
            this.bunifuToolTip1.SetToolTipIcon(this.pictureBox6, null);
            this.bunifuToolTip1.SetToolTipTitle(this.pictureBox6, "");
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(24, 59);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(24, 19);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 22;
            this.pictureBox5.TabStop = false;
            this.bunifuToolTip1.SetToolTip(this.pictureBox5, "shuffle");
            this.bunifuToolTip1.SetToolTipIcon(this.pictureBox5, null);
            this.bunifuToolTip1.SetToolTipTitle(this.pictureBox5, "");
            // 
            // repeat_once
            // 
            this.repeat_once.AutoSize = true;
            this.repeat_once.Location = new System.Drawing.Point(172, 63);
            this.repeat_once.Name = "repeat_once";
            this.repeat_once.Size = new System.Drawing.Size(15, 14);
            this.repeat_once.TabIndex = 21;
            this.bunifuToolTip1.SetToolTip(this.repeat_once, "");
            this.bunifuToolTip1.SetToolTipIcon(this.repeat_once, null);
            this.bunifuToolTip1.SetToolTipTitle(this.repeat_once, "");
            this.repeat_once.UseVisualStyleBackColor = true;
            // 
            // repeat
            // 
            this.repeat.AutoSize = true;
            this.repeat.Location = new System.Drawing.Point(116, 61);
            this.repeat.Name = "repeat";
            this.repeat.Size = new System.Drawing.Size(15, 14);
            this.repeat.TabIndex = 20;
            this.bunifuToolTip1.SetToolTip(this.repeat, "");
            this.bunifuToolTip1.SetToolTipIcon(this.repeat, null);
            this.bunifuToolTip1.SetToolTipTitle(this.repeat, "");
            this.repeat.UseVisualStyleBackColor = true;
            // 
            // shuffle
            // 
            this.shuffle.AutoSize = true;
            this.shuffle.Location = new System.Drawing.Point(55, 63);
            this.shuffle.Name = "shuffle";
            this.shuffle.Size = new System.Drawing.Size(15, 14);
            this.shuffle.TabIndex = 4;
            this.bunifuToolTip1.SetToolTip(this.shuffle, "");
            this.bunifuToolTip1.SetToolTipIcon(this.shuffle, null);
            this.bunifuToolTip1.SetToolTipTitle(this.shuffle, "");
            this.shuffle.UseVisualStyleBackColor = true;
            // 
            // progressbar
            // 
            this.progressbar.AllowAnimations = false;
            this.progressbar.Animation = 0;
            this.progressbar.AnimationSpeed = 220;
            this.progressbar.AnimationStep = 10;
            this.progressbar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            this.progressbar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("progressbar.BackgroundImage")));
            this.progressbar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            this.progressbar.BorderRadius = 9;
            this.progressbar.BorderThickness = 1;
            this.progressbar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.progressbar.Enabled = false;
            this.progressbar.Location = new System.Drawing.Point(272, 37);
            this.progressbar.Maximum = 100;
            this.progressbar.MaximumValue = 100;
            this.progressbar.Minimum = 0;
            this.progressbar.MinimumValue = 0;
            this.progressbar.Name = "progressbar";
            this.progressbar.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.progressbar.ProgressBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            this.progressbar.ProgressColorLeft = System.Drawing.Color.LightGreen;
            this.progressbar.ProgressColorRight = System.Drawing.Color.Lime;
            this.progressbar.Size = new System.Drawing.Size(276, 20);
            this.progressbar.TabIndex = 5;
            this.progressbar.TabStop = false;
            this.bunifuToolTip1.SetToolTip(this.progressbar, "");
            this.bunifuToolTip1.SetToolTipIcon(this.progressbar, null);
            this.bunifuToolTip1.SetToolTipTitle(this.progressbar, "");
            this.progressbar.Value = 0;
            this.progressbar.ValueByTransition = 0;
            this.progressbar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.bunifuProgressBar1_MouseDown);
            // 
            // lbl_track_start
            // 
            this.lbl_track_start.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_track_start.AutoSize = true;
            this.lbl_track_start.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_track_start.ForeColor = System.Drawing.Color.White;
            this.lbl_track_start.Location = new System.Drawing.Point(218, 35);
            this.lbl_track_start.Name = "lbl_track_start";
            this.lbl_track_start.Size = new System.Drawing.Size(50, 21);
            this.lbl_track_start.TabIndex = 16;
            this.lbl_track_start.Text = "00:00";
            this.bunifuToolTip1.SetToolTip(this.lbl_track_start, "");
            this.bunifuToolTip1.SetToolTipIcon(this.lbl_track_start, null);
            this.bunifuToolTip1.SetToolTipTitle(this.lbl_track_start, "");
            // 
            // pro_bar
            // 
            this.pro_bar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.pro_bar.BackColor = System.Drawing.Color.SpringGreen;
            this.pro_bar.Location = new System.Drawing.Point(272, 37);
            this.pro_bar.Name = "pro_bar";
            this.pro_bar.Size = new System.Drawing.Size(276, 20);
            this.pro_bar.TabIndex = 9;
            this.bunifuToolTip1.SetToolTip(this.pro_bar, "");
            this.bunifuToolTip1.SetToolTipIcon(this.pro_bar, null);
            this.bunifuToolTip1.SetToolTipTitle(this.pro_bar, "");
            this.pro_bar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pro_bar_MouseDown);
            // 
            // btn_pause
            // 
            this.btn_pause.ActiveImage = null;
            this.btn_pause.AllowAnimations = true;
            this.btn_pause.AllowBuffering = false;
            this.btn_pause.AllowToggling = false;
            this.btn_pause.AllowZooming = true;
            this.btn_pause.AllowZoomingOnFocus = false;
            this.btn_pause.BackColor = System.Drawing.Color.Transparent;
            this.btn_pause.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_pause.ErrorImage = ((System.Drawing.Image)(resources.GetObject("btn_pause.ErrorImage")));
            this.btn_pause.FadeWhenInactive = false;
            this.btn_pause.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.btn_pause.Image = ((System.Drawing.Image)(resources.GetObject("btn_pause.Image")));
            this.btn_pause.ImageActive = null;
            this.btn_pause.ImageLocation = null;
            this.btn_pause.ImageMargin = 10;
            this.btn_pause.ImageSize = new System.Drawing.Size(32, 29);
            this.btn_pause.ImageZoomSize = new System.Drawing.Size(42, 39);
            this.btn_pause.InitialImage = ((System.Drawing.Image)(resources.GetObject("btn_pause.InitialImage")));
            this.btn_pause.Location = new System.Drawing.Point(88, 15);
            this.btn_pause.Name = "btn_pause";
            this.btn_pause.Rotation = 0;
            this.btn_pause.ShowActiveImage = true;
            this.btn_pause.ShowCursorChanges = true;
            this.btn_pause.ShowImageBorders = true;
            this.btn_pause.ShowSizeMarkers = false;
            this.btn_pause.Size = new System.Drawing.Size(42, 39);
            this.btn_pause.TabIndex = 18;
            this.bunifuToolTip1.SetToolTip(this.btn_pause, "Pause");
            this.bunifuToolTip1.SetToolTipIcon(this.btn_pause, null);
            this.btn_pause.ToolTipText = "";
            this.bunifuToolTip1.SetToolTipTitle(this.btn_pause, "");
            this.btn_pause.WaitOnLoad = false;
            this.btn_pause.Zoom = 10;
            this.btn_pause.ZoomSpeed = 10;
            this.btn_pause.Click += new System.EventHandler(this.btn_pause_Click);
            // 
            // p_bar
            // 
            this.p_bar.BackColor = System.Drawing.Color.SkyBlue;
            this.p_bar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.p_bar.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.p_bar.Location = new System.Drawing.Point(200, 24);
            this.p_bar.MaximumSize = new System.Drawing.Size(0, 100);
            this.p_bar.Name = "p_bar";
            this.p_bar.Size = new System.Drawing.Size(0, 100);
            this.p_bar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.p_bar.TabIndex = 17;
            this.bunifuToolTip1.SetToolTip(this.p_bar, "");
            this.bunifuToolTip1.SetToolTipIcon(this.p_bar, null);
            this.bunifuToolTip1.SetToolTipTitle(this.p_bar, "");
            this.p_bar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.progressBar1_MouseDown);
            // 
            // lbl_track_end
            // 
            this.lbl_track_end.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_track_end.AutoSize = true;
            this.lbl_track_end.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_track_end.ForeColor = System.Drawing.Color.White;
            this.lbl_track_end.Location = new System.Drawing.Point(547, 35);
            this.lbl_track_end.Name = "lbl_track_end";
            this.lbl_track_end.Size = new System.Drawing.Size(50, 21);
            this.lbl_track_end.TabIndex = 16;
            this.lbl_track_end.Text = "00:00";
            this.bunifuToolTip1.SetToolTip(this.lbl_track_end, "");
            this.bunifuToolTip1.SetToolTipIcon(this.lbl_track_end, null);
            this.bunifuToolTip1.SetToolTipTitle(this.lbl_track_end, "");
            // 
            // volume
            // 
            this.volume.AllowCursorChanges = true;
            this.volume.AllowHomeEndKeysDetection = false;
            this.volume.AllowIncrementalClickMoves = true;
            this.volume.AllowMouseDownEffects = false;
            this.volume.AllowMouseHoverEffects = false;
            this.volume.AllowScrollingAnimations = true;
            this.volume.AllowScrollKeysDetection = true;
            this.volume.AllowScrollOptionsMenu = true;
            this.volume.AllowShrinkingOnFocusLost = false;
            this.volume.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.volume.BackColor = System.Drawing.Color.Transparent;
            this.volume.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("volume.BackgroundImage")));
            this.volume.BindingContainer = null;
            this.volume.BorderRadius = 2;
            this.volume.BorderThickness = 1;
            this.volume.Cursor = System.Windows.Forms.Cursors.Hand;
            this.volume.DrawThickBorder = false;
            this.volume.DurationBeforeShrink = 2000;
            this.volume.ElapsedColor = System.Drawing.Color.CornflowerBlue;
            this.volume.LargeChange = 10;
            this.volume.Location = new System.Drawing.Point(633, 33);
            this.volume.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.volume.Maximum = 100;
            this.volume.Minimum = 0;
            this.volume.MinimumSize = new System.Drawing.Size(0, 25);
            this.volume.MinimumThumbLength = 18;
            this.volume.Name = "volume";
            this.volume.OnDisable.ScrollBarBorderColor = System.Drawing.Color.Silver;
            this.volume.OnDisable.ScrollBarColor = System.Drawing.Color.Transparent;
            this.volume.OnDisable.ThumbColor = System.Drawing.Color.Silver;
            this.volume.ScrollBarBorderColor = System.Drawing.Color.White;
            this.volume.ScrollBarColor = System.Drawing.Color.White;
            this.volume.ShrinkSizeLimit = 3;
            this.volume.Size = new System.Drawing.Size(85, 25);
            this.volume.SliderColor = System.Drawing.Color.White;
            this.volume.SliderStyle = Bunifu.UI.WinForms.BunifuHSlider.SliderStyles.Thin;
            this.volume.SliderThumbStyle = Utilities.BunifuSlider.BunifuHScrollBar.SliderThumbStyles.Circular;
            this.volume.SmallChange = 1;
            this.volume.TabIndex = 11;
            this.volume.ThumbColor = System.Drawing.Color.DodgerBlue;
            this.volume.ThumbFillColor = System.Drawing.SystemColors.Control;
            this.volume.ThumbLength = 18;
            this.volume.ThumbMargin = 1;
            this.volume.ThumbSize = Bunifu.UI.WinForms.BunifuHSlider.ThumbSizes.Medium;
            this.volume.ThumbStyle = Bunifu.UI.WinForms.BunifuHSlider.ThumbStyles.Outline;
            this.bunifuToolTip1.SetToolTip(this.volume, "");
            this.bunifuToolTip1.SetToolTipIcon(this.volume, null);
            this.bunifuToolTip1.SetToolTipTitle(this.volume, "");
            this.volume.Value = 50;
            this.volume.Scroll += new System.EventHandler<Utilities.BunifuSlider.BunifuHScrollBar.ScrollEventArgs>(this.volume_Scroll);
            // 
            // btn_next
            // 
            this.btn_next.ActiveImage = null;
            this.btn_next.AllowAnimations = true;
            this.btn_next.AllowBuffering = false;
            this.btn_next.AllowToggling = false;
            this.btn_next.AllowZooming = true;
            this.btn_next.AllowZoomingOnFocus = false;
            this.btn_next.BackColor = System.Drawing.Color.Transparent;
            this.btn_next.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_next.ErrorImage = ((System.Drawing.Image)(resources.GetObject("btn_next.ErrorImage")));
            this.btn_next.FadeWhenInactive = false;
            this.btn_next.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.btn_next.Image = ((System.Drawing.Image)(resources.GetObject("btn_next.Image")));
            this.btn_next.ImageActive = null;
            this.btn_next.ImageLocation = null;
            this.btn_next.ImageMargin = 10;
            this.btn_next.ImageSize = new System.Drawing.Size(32, 29);
            this.btn_next.ImageZoomSize = new System.Drawing.Size(42, 39);
            this.btn_next.InitialImage = ((System.Drawing.Image)(resources.GetObject("btn_next.InitialImage")));
            this.btn_next.Location = new System.Drawing.Point(169, 15);
            this.btn_next.Name = "btn_next";
            this.btn_next.Rotation = 0;
            this.btn_next.ShowActiveImage = true;
            this.btn_next.ShowCursorChanges = true;
            this.btn_next.ShowImageBorders = true;
            this.btn_next.ShowSizeMarkers = false;
            this.btn_next.Size = new System.Drawing.Size(42, 39);
            this.btn_next.TabIndex = 10;
            this.bunifuToolTip1.SetToolTip(this.btn_next, "Next");
            this.bunifuToolTip1.SetToolTipIcon(this.btn_next, null);
            this.btn_next.ToolTipText = "";
            this.bunifuToolTip1.SetToolTipTitle(this.btn_next, "");
            this.btn_next.WaitOnLoad = false;
            this.btn_next.Zoom = 10;
            this.btn_next.ZoomSpeed = 10;
            this.btn_next.Click += new System.EventHandler(this.btn_next_Click);
            // 
            // btn_Stop
            // 
            this.btn_Stop.ActiveImage = null;
            this.btn_Stop.AllowAnimations = true;
            this.btn_Stop.AllowBuffering = false;
            this.btn_Stop.AllowToggling = false;
            this.btn_Stop.AllowZooming = true;
            this.btn_Stop.AllowZoomingOnFocus = false;
            this.btn_Stop.BackColor = System.Drawing.Color.Transparent;
            this.btn_Stop.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_Stop.ErrorImage = ((System.Drawing.Image)(resources.GetObject("btn_Stop.ErrorImage")));
            this.btn_Stop.FadeWhenInactive = false;
            this.btn_Stop.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.btn_Stop.Image = ((System.Drawing.Image)(resources.GetObject("btn_Stop.Image")));
            this.btn_Stop.ImageActive = null;
            this.btn_Stop.ImageLocation = null;
            this.btn_Stop.ImageMargin = 10;
            this.btn_Stop.ImageSize = new System.Drawing.Size(32, 29);
            this.btn_Stop.ImageZoomSize = new System.Drawing.Size(42, 39);
            this.btn_Stop.InitialImage = ((System.Drawing.Image)(resources.GetObject("btn_Stop.InitialImage")));
            this.btn_Stop.Location = new System.Drawing.Point(129, 15);
            this.btn_Stop.Name = "btn_Stop";
            this.btn_Stop.Rotation = 0;
            this.btn_Stop.ShowActiveImage = true;
            this.btn_Stop.ShowCursorChanges = true;
            this.btn_Stop.ShowImageBorders = true;
            this.btn_Stop.ShowSizeMarkers = false;
            this.btn_Stop.Size = new System.Drawing.Size(42, 39);
            this.btn_Stop.TabIndex = 10;
            this.bunifuToolTip1.SetToolTip(this.btn_Stop, "Stop");
            this.bunifuToolTip1.SetToolTipIcon(this.btn_Stop, null);
            this.btn_Stop.ToolTipText = "";
            this.bunifuToolTip1.SetToolTipTitle(this.btn_Stop, "");
            this.btn_Stop.WaitOnLoad = false;
            this.btn_Stop.Zoom = 10;
            this.btn_Stop.ZoomSpeed = 10;
            this.btn_Stop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btn_preview
            // 
            this.btn_preview.ActiveImage = null;
            this.btn_preview.AllowAnimations = true;
            this.btn_preview.AllowBuffering = false;
            this.btn_preview.AllowToggling = false;
            this.btn_preview.AllowZooming = true;
            this.btn_preview.AllowZoomingOnFocus = false;
            this.btn_preview.BackColor = System.Drawing.Color.Transparent;
            this.btn_preview.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_preview.ErrorImage = ((System.Drawing.Image)(resources.GetObject("btn_preview.ErrorImage")));
            this.btn_preview.FadeWhenInactive = false;
            this.btn_preview.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.btn_preview.Image = ((System.Drawing.Image)(resources.GetObject("btn_preview.Image")));
            this.btn_preview.ImageActive = null;
            this.btn_preview.ImageLocation = null;
            this.btn_preview.ImageMargin = 10;
            this.btn_preview.ImageSize = new System.Drawing.Size(32, 29);
            this.btn_preview.ImageZoomSize = new System.Drawing.Size(42, 39);
            this.btn_preview.InitialImage = ((System.Drawing.Image)(resources.GetObject("btn_preview.InitialImage")));
            this.btn_preview.Location = new System.Drawing.Point(6, 15);
            this.btn_preview.Name = "btn_preview";
            this.btn_preview.Rotation = 0;
            this.btn_preview.ShowActiveImage = true;
            this.btn_preview.ShowCursorChanges = true;
            this.btn_preview.ShowImageBorders = true;
            this.btn_preview.ShowSizeMarkers = false;
            this.btn_preview.Size = new System.Drawing.Size(42, 39);
            this.btn_preview.TabIndex = 10;
            this.bunifuToolTip1.SetToolTip(this.btn_preview, "Prev");
            this.bunifuToolTip1.SetToolTipIcon(this.btn_preview, null);
            this.btn_preview.ToolTipText = "";
            this.bunifuToolTip1.SetToolTipTitle(this.btn_preview, "");
            this.btn_preview.WaitOnLoad = false;
            this.btn_preview.Zoom = 10;
            this.btn_preview.ZoomSpeed = 10;
            this.btn_preview.Click += new System.EventHandler(this.btn_preview_Click);
            // 
            // btn_play
            // 
            this.btn_play.ActiveImage = null;
            this.btn_play.AllowAnimations = true;
            this.btn_play.AllowBuffering = false;
            this.btn_play.AllowToggling = false;
            this.btn_play.AllowZooming = true;
            this.btn_play.AllowZoomingOnFocus = false;
            this.btn_play.BackColor = System.Drawing.Color.Transparent;
            this.btn_play.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_play.ErrorImage = ((System.Drawing.Image)(resources.GetObject("btn_play.ErrorImage")));
            this.btn_play.FadeWhenInactive = false;
            this.btn_play.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.btn_play.Image = ((System.Drawing.Image)(resources.GetObject("btn_play.Image")));
            this.btn_play.ImageActive = null;
            this.btn_play.ImageLocation = null;
            this.btn_play.ImageMargin = 10;
            this.btn_play.ImageSize = new System.Drawing.Size(32, 29);
            this.btn_play.ImageZoomSize = new System.Drawing.Size(42, 39);
            this.btn_play.InitialImage = ((System.Drawing.Image)(resources.GetObject("btn_play.InitialImage")));
            this.btn_play.Location = new System.Drawing.Point(47, 15);
            this.btn_play.Name = "btn_play";
            this.btn_play.Rotation = 0;
            this.btn_play.ShowActiveImage = true;
            this.btn_play.ShowCursorChanges = true;
            this.btn_play.ShowImageBorders = true;
            this.btn_play.ShowSizeMarkers = false;
            this.btn_play.Size = new System.Drawing.Size(42, 39);
            this.btn_play.TabIndex = 9;
            this.bunifuToolTip1.SetToolTip(this.btn_play, "Play");
            this.bunifuToolTip1.SetToolTipIcon(this.btn_play, null);
            this.btn_play.ToolTipText = "";
            this.bunifuToolTip1.SetToolTipTitle(this.btn_play, "");
            this.btn_play.WaitOnLoad = false;
            this.btn_play.Zoom = 10;
            this.btn_play.ZoomSpeed = 10;
            this.btn_play.Click += new System.EventHandler(this.btn_playClick);
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
            this.pictureBox7.Location = new System.Drawing.Point(143, 55);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(28, 28);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 24;
            this.pictureBox7.TabStop = false;
            this.bunifuToolTip1.SetToolTip(this.pictureBox7, "repeat_once");
            this.bunifuToolTip1.SetToolTipIcon(this.pictureBox7, null);
            this.bunifuToolTip1.SetToolTipTitle(this.pictureBox7, "");
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "[MP3 File(*.mp3)|*.mp3]";
            this.openFileDialog1.InitialDirectory = "C:";
            // 
            // bunifuToolTip1
            // 
            this.bunifuToolTip1.Active = true;
            this.bunifuToolTip1.AlignTextWithTitle = false;
            this.bunifuToolTip1.AllowAutoClose = false;
            this.bunifuToolTip1.AllowFading = true;
            this.bunifuToolTip1.AutoCloseDuration = 5000;
            this.bunifuToolTip1.BackColor = System.Drawing.SystemColors.Control;
            this.bunifuToolTip1.BorderColor = System.Drawing.Color.Gainsboro;
            this.bunifuToolTip1.ClickToShowDisplayControl = false;
            this.bunifuToolTip1.ConvertNewlinesToBreakTags = true;
            this.bunifuToolTip1.DisplayControl = null;
            this.bunifuToolTip1.EntryAnimationSpeed = 350;
            this.bunifuToolTip1.ExitAnimationSpeed = 200;
            this.bunifuToolTip1.GenerateAutoCloseDuration = false;
            this.bunifuToolTip1.IconMargin = 6;
            this.bunifuToolTip1.InitialDelay = 0;
            this.bunifuToolTip1.Name = "bunifuToolTip1";
            this.bunifuToolTip1.Opacity = 1D;
            this.bunifuToolTip1.OverrideToolTipTitles = false;
            this.bunifuToolTip1.Padding = new System.Windows.Forms.Padding(10);
            this.bunifuToolTip1.ReshowDelay = 100;
            this.bunifuToolTip1.ShowAlways = true;
            this.bunifuToolTip1.ShowBorders = false;
            this.bunifuToolTip1.ShowIcons = true;
            this.bunifuToolTip1.ShowShadows = true;
            this.bunifuToolTip1.Tag = null;
            this.bunifuToolTip1.TextFont = new System.Drawing.Font("Segoe UI", 9F);
            this.bunifuToolTip1.TextForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuToolTip1.TextMargin = 2;
            this.bunifuToolTip1.TitleFont = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.bunifuToolTip1.TitleForeColor = System.Drawing.Color.Black;
            this.bunifuToolTip1.ToolTipPosition = new System.Drawing.Point(0, 0);
            this.bunifuToolTip1.ToolTipTitle = null;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 25;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(248)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(962, 600);
            this.Controls.Add(this.bunifuPages1);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlSideBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.pnlSideBar.ResumeLayout(false);
            this.pnlSideBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.bunifuPages1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_art)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlSideBar;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnPlaying;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnPlaylists;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnExplore;
        private System.Windows.Forms.Panel pnlHeader;
        private Bunifu.UI.WinForms.BunifuFormDock bunifuFormDock1;
        private Bunifu.UI.WinForms.BunifuShapes indicator;
        private Bunifu.UI.WinForms.BunifuShapes btnSidebar;
        private Bunifu.UI.WinForms.BunifuPages bunifuPages1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.UI.WinForms.BunifuImageButton btnClose;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Bunifu.UI.WinForms.BunifuImageButton btn_next;
        private Bunifu.UI.WinForms.BunifuImageButton btn_Stop;
        private Bunifu.UI.WinForms.BunifuImageButton btn_preview;
        private Bunifu.UI.WinForms.BunifuImageButton btn_play;
        private Bunifu.UI.WinForms.BunifuHSlider volume;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private AxWMPLib.AxWindowsMediaPlayer player;
        private Bunifu.UI.WinForms.BunifuToolTip bunifuToolTip1;
        private System.Windows.Forms.Label lbl_track_end;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btn_open;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.ListBox track_list;
        private System.Windows.Forms.ProgressBar p_bar;
        private Bunifu.UI.WinForms.BunifuImageButton btn_pause;
        private System.Windows.Forms.ProgressBar pro_bar;
        private System.Windows.Forms.Label lbl_track_start;
        private System.Windows.Forms.PictureBox pictureBox4;
        private Bunifu.UI.WinForms.BunifuProgressBar progressbar;
        private System.Windows.Forms.CheckBox repeat;
        private System.Windows.Forms.CheckBox shuffle;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.CheckBox repeat_once;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.PictureBox pic_art;
        private System.Windows.Forms.Timer timer2;
        private Bunifu.UI.WinForms.BunifuImageButton btnMute;
        private Bunifu.UI.WinForms.BunifuImageButton btnMaxVol;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.ListBox lst_m2playlist;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_music2;
        private System.Windows.Forms.ListBox lst_m1playlist;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_music1;
        private System.Windows.Forms.Label SongTitle;
        private System.Windows.Forms.Label Album;
        private System.Windows.Forms.Label Artist;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnLyrics;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label Artist2;
        private System.Windows.Forms.Label SongTitle2;
    }
}

