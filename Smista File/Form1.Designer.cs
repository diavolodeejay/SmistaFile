namespace Smista_File
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.SmistamentoDataWorker = new System.ComponentModel.BackgroundWorker();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.esciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informazioniToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aiutoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SourceText = new System.Windows.Forms.TextBox();
            this.SfogliaSource = new System.Windows.Forms.Button();
            this.delPulsante = new System.Windows.Forms.Button();
            this.SmistaAsk = new System.Windows.Forms.Label();
            this.ComboMetodo = new System.Windows.Forms.ComboBox();
            this.tut1 = new System.Windows.Forms.Label();
            this.DestText = new System.Windows.Forms.TextBox();
            this.sfogliadest = new System.Windows.Forms.Button();
            this.destlabel = new System.Windows.Forms.Label();
            this.tempomeseradio = new System.Windows.Forms.RadioButton();
            this.tempoannoradio = new System.Windows.Forms.RadioButton();
            this.tempotooltip = new System.Windows.Forms.Label();
            this.AvviaButton = new System.Windows.Forms.Button();
            this.Everylabel = new System.Windows.Forms.Label();
            this.Repeat = new System.Windows.Forms.CheckBox();
            this.RepeatValue = new System.Windows.Forms.NumericUpDown();
            this.Everylabel2 = new System.Windows.Forms.Label();
            this.StopButton = new System.Windows.Forms.Button();
            this.Progress = new System.Windows.Forms.ProgressBar();
            this.DocumentiBox = new System.Windows.Forms.CheckBox();
            this.ImageBox = new System.Windows.Forms.CheckBox();
            this.VideoBox = new System.Windows.Forms.CheckBox();
            this.ArchiviBox = new System.Windows.Forms.CheckBox();
            this.MusicaBox = new System.Windows.Forms.CheckBox();
            this.exeBox = new System.Windows.Forms.CheckBox();
            this.AltroBox = new System.Windows.Forms.CheckBox();
            this.smallcheck = new System.Windows.Forms.CheckBox();
            this.smallMedcheck = new System.Windows.Forms.CheckBox();
            this.mediumcheck = new System.Windows.Forms.CheckBox();
            this.medbigcheck = new System.Windows.Forms.CheckBox();
            this.bigcgeck = new System.Windows.Forms.CheckBox();
            this.hugecheck = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.megacheck = new System.Windows.Forms.CheckBox();
            this.shortFoldersCheck = new System.Windows.Forms.CheckBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RepeatValue)).BeginInit();
            this.SuspendLayout();
            // 
            // SmistamentoDataWorker
            // 
            this.SmistamentoDataWorker.WorkerReportsProgress = true;
            this.SmistamentoDataWorker.WorkerSupportsCancellation = true;
            this.SmistamentoDataWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.SmistamentoDataWorker_DoWork);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.informazioniToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(894, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.esciToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(37, 20);
            this.toolStripMenuItem1.Text = "File";
            // 
            // esciToolStripMenuItem
            // 
            this.esciToolStripMenuItem.Name = "esciToolStripMenuItem";
            this.esciToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.esciToolStripMenuItem.Text = "Esci";
            this.esciToolStripMenuItem.Click += new System.EventHandler(this.esciToolStripMenuItem_Click);
            // 
            // informazioniToolStripMenuItem
            // 
            this.informazioniToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.infoToolStripMenuItem,
            this.aiutoToolStripMenuItem});
            this.informazioniToolStripMenuItem.Name = "informazioniToolStripMenuItem";
            this.informazioniToolStripMenuItem.Size = new System.Drawing.Size(24, 20);
            this.informazioniToolStripMenuItem.Text = "?";
            // 
            // infoToolStripMenuItem
            // 
            this.infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            this.infoToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.infoToolStripMenuItem.Text = "Informazioni";
            this.infoToolStripMenuItem.Click += new System.EventHandler(this.infoToolStripMenuItem_Click);
            // 
            // aiutoToolStripMenuItem
            // 
            this.aiutoToolStripMenuItem.Enabled = false;
            this.aiutoToolStripMenuItem.Name = "aiutoToolStripMenuItem";
            this.aiutoToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.aiutoToolStripMenuItem.Text = "Aiuto";
            this.aiutoToolStripMenuItem.Visible = false;
            this.aiutoToolStripMenuItem.Click += new System.EventHandler(this.aiutoToolStripMenuItem_Click);
            // 
            // SourceText
            // 
            this.SourceText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.SourceText.Location = new System.Drawing.Point(45, 70);
            this.SourceText.Name = "SourceText";
            this.SourceText.ReadOnly = true;
            this.SourceText.Size = new System.Drawing.Size(350, 26);
            this.SourceText.TabIndex = 2;
            // 
            // SfogliaSource
            // 
            this.SfogliaSource.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.SfogliaSource.Location = new System.Drawing.Point(400, 69);
            this.SfogliaSource.Name = "SfogliaSource";
            this.SfogliaSource.Size = new System.Drawing.Size(75, 25);
            this.SfogliaSource.TabIndex = 3;
            this.SfogliaSource.Text = "Sfoglia";
            this.SfogliaSource.UseVisualStyleBackColor = true;
            this.SfogliaSource.Click += new System.EventHandler(this.SfogliaSource_Click);
            // 
            // delPulsante
            // 
            this.delPulsante.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delPulsante.Location = new System.Drawing.Point(790, 50);
            this.delPulsante.Name = "delPulsante";
            this.delPulsante.Size = new System.Drawing.Size(75, 25);
            this.delPulsante.TabIndex = 4;
            this.delPulsante.Text = "Elimina";
            this.delPulsante.UseVisualStyleBackColor = true;
            this.delPulsante.Visible = false;
            // 
            // SmistaAsk
            // 
            this.SmistaAsk.AutoSize = true;
            this.SmistaAsk.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SmistaAsk.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.SmistaAsk.Location = new System.Drawing.Point(42, 137);
            this.SmistaAsk.Name = "SmistaAsk";
            this.SmistaAsk.Size = new System.Drawing.Size(159, 16);
            this.SmistaAsk.TabIndex = 5;
            this.SmistaAsk.Text = "Come vuoi smistare i file?";
            // 
            // ComboMetodo
            // 
            this.ComboMetodo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboMetodo.Enabled = false;
            this.ComboMetodo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.ComboMetodo.FormattingEnabled = true;
            this.ComboMetodo.Items.AddRange(new object[] {
            "Per Tipo",
            "Per Dimensione",
            "Per Data"});
            this.ComboMetodo.Location = new System.Drawing.Point(45, 156);
            this.ComboMetodo.Name = "ComboMetodo";
            this.ComboMetodo.Size = new System.Drawing.Size(160, 24);
            this.ComboMetodo.TabIndex = 7;
            this.ComboMetodo.SelectedIndexChanged += new System.EventHandler(this.ComboMetodo_SelectedIndexChanged);
            // 
            // tut1
            // 
            this.tut1.AutoSize = true;
            this.tut1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.tut1.Location = new System.Drawing.Point(42, 50);
            this.tut1.Name = "tut1";
            this.tut1.Size = new System.Drawing.Size(180, 16);
            this.tut1.TabIndex = 8;
            this.tut1.Text = "Scegli la cartella da smistare";
            // 
            // DestText
            // 
            this.DestText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.DestText.Location = new System.Drawing.Point(45, 487);
            this.DestText.Name = "DestText";
            this.DestText.ReadOnly = true;
            this.DestText.Size = new System.Drawing.Size(350, 26);
            this.DestText.TabIndex = 9;
            // 
            // sfogliadest
            // 
            this.sfogliadest.Enabled = false;
            this.sfogliadest.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.sfogliadest.Location = new System.Drawing.Point(400, 486);
            this.sfogliadest.Name = "sfogliadest";
            this.sfogliadest.Size = new System.Drawing.Size(75, 25);
            this.sfogliadest.TabIndex = 10;
            this.sfogliadest.Text = "Sfoglia";
            this.sfogliadest.UseVisualStyleBackColor = true;
            this.sfogliadest.Click += new System.EventHandler(this.sfogliadest_Click);
            // 
            // destlabel
            // 
            this.destlabel.AutoSize = true;
            this.destlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.destlabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.destlabel.Location = new System.Drawing.Point(42, 468);
            this.destlabel.Name = "destlabel";
            this.destlabel.Size = new System.Drawing.Size(200, 16);
            this.destlabel.TabIndex = 11;
            this.destlabel.Text = "Scegli la cartella di destinazione";
            // 
            // tempomeseradio
            // 
            this.tempomeseradio.AutoSize = true;
            this.tempomeseradio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.tempomeseradio.Location = new System.Drawing.Point(45, 200);
            this.tempomeseradio.Name = "tempomeseradio";
            this.tempomeseradio.Size = new System.Drawing.Size(127, 20);
            this.tempomeseradio.TabIndex = 12;
            this.tempomeseradio.TabStop = true;
            this.tempomeseradio.Text = "Smista per mese";
            this.tempomeseradio.UseVisualStyleBackColor = true;
            this.tempomeseradio.Visible = false;
            this.tempomeseradio.CheckedChanged += new System.EventHandler(this.tempomeseradio_CheckedChanged);
            // 
            // tempoannoradio
            // 
            this.tempoannoradio.AutoSize = true;
            this.tempoannoradio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.tempoannoradio.Location = new System.Drawing.Point(45, 226);
            this.tempoannoradio.Name = "tempoannoradio";
            this.tempoannoradio.Size = new System.Drawing.Size(123, 20);
            this.tempoannoradio.TabIndex = 13;
            this.tempoannoradio.TabStop = true;
            this.tempoannoradio.Text = "Smista per anno";
            this.tempoannoradio.UseVisualStyleBackColor = true;
            this.tempoannoradio.Visible = false;
            this.tempoannoradio.CheckedChanged += new System.EventHandler(this.tempoannoradio_CheckedChanged);
            // 
            // tempotooltip
            // 
            this.tempotooltip.Location = new System.Drawing.Point(0, 0);
            this.tempotooltip.Name = "tempotooltip";
            this.tempotooltip.Size = new System.Drawing.Size(100, 23);
            this.tempotooltip.TabIndex = 0;
            // 
            // AvviaButton
            // 
            this.AvviaButton.Enabled = false;
            this.AvviaButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.AvviaButton.Location = new System.Drawing.Point(790, 486);
            this.AvviaButton.Name = "AvviaButton";
            this.AvviaButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.AvviaButton.Size = new System.Drawing.Size(75, 25);
            this.AvviaButton.TabIndex = 15;
            this.AvviaButton.Text = "Avvia";
            this.AvviaButton.UseVisualStyleBackColor = true;
            this.AvviaButton.Click += new System.EventHandler(this.AvviaButton_Click);
            // 
            // Everylabel
            // 
            this.Everylabel.AutoSize = true;
            this.Everylabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.Everylabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Everylabel.Location = new System.Drawing.Point(482, 166);
            this.Everylabel.Name = "Everylabel";
            this.Everylabel.Size = new System.Drawing.Size(79, 16);
            this.Everylabel.TabIndex = 16;
            this.Everylabel.Text = "Esegui ogni";
            // 
            // Repeat
            // 
            this.Repeat.AutoSize = true;
            this.Repeat.Enabled = false;
            this.Repeat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.Repeat.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Repeat.Location = new System.Drawing.Point(485, 136);
            this.Repeat.Name = "Repeat";
            this.Repeat.Size = new System.Drawing.Size(175, 20);
            this.Repeat.TabIndex = 17;
            this.Repeat.Text = "Esegui automaticamente";
            this.Repeat.UseVisualStyleBackColor = true;
            this.Repeat.CheckedChanged += new System.EventHandler(this.Repeat_CheckedChanged);
            // 
            // RepeatValue
            // 
            this.RepeatValue.Cursor = System.Windows.Forms.Cursors.Default;
            this.RepeatValue.Enabled = false;
            this.RepeatValue.Location = new System.Drawing.Point(556, 164);
            this.RepeatValue.Maximum = new decimal(new int[] {
            120,
            0,
            0,
            0});
            this.RepeatValue.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.RepeatValue.Name = "RepeatValue";
            this.RepeatValue.Size = new System.Drawing.Size(51, 20);
            this.RepeatValue.TabIndex = 18;
            this.RepeatValue.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.RepeatValue.ValueChanged += new System.EventHandler(this.RepeatValue_ValueChanged);
            // 
            // Everylabel2
            // 
            this.Everylabel2.AutoSize = true;
            this.Everylabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.Everylabel2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Everylabel2.Location = new System.Drawing.Point(612, 166);
            this.Everylabel2.Name = "Everylabel2";
            this.Everylabel2.Size = new System.Drawing.Size(50, 16);
            this.Everylabel2.TabIndex = 19;
            this.Everylabel2.Text = "minuto.";
            // 
            // StopButton
            // 
            this.StopButton.Enabled = false;
            this.StopButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.StopButton.Location = new System.Drawing.Point(709, 486);
            this.StopButton.Name = "StopButton";
            this.StopButton.Size = new System.Drawing.Size(75, 25);
            this.StopButton.TabIndex = 20;
            this.StopButton.Text = "Stop";
            this.StopButton.UseVisualStyleBackColor = true;
            this.StopButton.Click += new System.EventHandler(this.StopButton_Click);
            // 
            // Progress
            // 
            this.Progress.Location = new System.Drawing.Point(45, 560);
            this.Progress.Name = "Progress";
            this.Progress.Size = new System.Drawing.Size(820, 23);
            this.Progress.TabIndex = 21;
            // 
            // DocumentiBox
            // 
            this.DocumentiBox.AutoSize = true;
            this.DocumentiBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.DocumentiBox.Location = new System.Drawing.Point(45, 200);
            this.DocumentiBox.Name = "DocumentiBox";
            this.DocumentiBox.Size = new System.Drawing.Size(354, 20);
            this.DocumentiBox.TabIndex = 22;
            this.DocumentiBox.Text = "Smista i documenti (Word, Excel, PowerPoint, PDF ecc)";
            this.DocumentiBox.UseVisualStyleBackColor = true;
            this.DocumentiBox.Visible = false;
            this.DocumentiBox.CheckedChanged += new System.EventHandler(this.DocumentiBox_CheckedChanged);
            // 
            // ImageBox
            // 
            this.ImageBox.AutoSize = true;
            this.ImageBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.ImageBox.Location = new System.Drawing.Point(45, 226);
            this.ImageBox.Name = "ImageBox";
            this.ImageBox.Size = new System.Drawing.Size(139, 20);
            this.ImageBox.TabIndex = 23;
            this.ImageBox.Text = "Smista le immagini";
            this.ImageBox.UseVisualStyleBackColor = true;
            this.ImageBox.Visible = false;
            this.ImageBox.CheckedChanged += new System.EventHandler(this.ImageBox_CheckedChanged);
            // 
            // VideoBox
            // 
            this.VideoBox.AutoSize = true;
            this.VideoBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.VideoBox.Location = new System.Drawing.Point(45, 253);
            this.VideoBox.Name = "VideoBox";
            this.VideoBox.Size = new System.Drawing.Size(111, 20);
            this.VideoBox.TabIndex = 24;
            this.VideoBox.Text = "Smista i video";
            this.VideoBox.UseVisualStyleBackColor = true;
            this.VideoBox.Visible = false;
            this.VideoBox.CheckedChanged += new System.EventHandler(this.VideoBox_CheckedChanged);
            // 
            // ArchiviBox
            // 
            this.ArchiviBox.AutoSize = true;
            this.ArchiviBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.ArchiviBox.Location = new System.Drawing.Point(45, 332);
            this.ArchiviBox.Name = "ArchiviBox";
            this.ArchiviBox.Size = new System.Drawing.Size(215, 20);
            this.ArchiviBox.TabIndex = 25;
            this.ArchiviBox.Text = "Smista gli archivi (zip,rar,7z ecc)";
            this.ArchiviBox.UseVisualStyleBackColor = true;
            this.ArchiviBox.Visible = false;
            this.ArchiviBox.CheckedChanged += new System.EventHandler(this.ArchiviBox_CheckedChanged);
            // 
            // MusicaBox
            // 
            this.MusicaBox.AutoSize = true;
            this.MusicaBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.MusicaBox.Location = new System.Drawing.Point(45, 279);
            this.MusicaBox.Name = "MusicaBox";
            this.MusicaBox.Size = new System.Drawing.Size(131, 20);
            this.MusicaBox.TabIndex = 26;
            this.MusicaBox.Text = "Smista i file audio";
            this.MusicaBox.UseVisualStyleBackColor = true;
            this.MusicaBox.Visible = false;
            this.MusicaBox.CheckedChanged += new System.EventHandler(this.MusicaBox_CheckedChanged);
            // 
            // exeBox
            // 
            this.exeBox.AutoSize = true;
            this.exeBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.exeBox.Location = new System.Drawing.Point(45, 306);
            this.exeBox.Name = "exeBox";
            this.exeBox.Size = new System.Drawing.Size(142, 20);
            this.exeBox.TabIndex = 27;
            this.exeBox.Text = "Smista i programmi";
            this.exeBox.UseVisualStyleBackColor = true;
            this.exeBox.Visible = false;
            this.exeBox.CheckedChanged += new System.EventHandler(this.exeBox_CheckedChanged);
            // 
            // AltroBox
            // 
            this.AltroBox.AutoSize = true;
            this.AltroBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.AltroBox.Location = new System.Drawing.Point(45, 359);
            this.AltroBox.Name = "AltroBox";
            this.AltroBox.Size = new System.Drawing.Size(304, 20);
            this.AltroBox.TabIndex = 28;
            this.AltroBox.Text = "Sposta gli elementi rimanenti in un altra cartella";
            this.AltroBox.UseVisualStyleBackColor = true;
            this.AltroBox.Visible = false;
            this.AltroBox.CheckedChanged += new System.EventHandler(this.AltroBox_CheckedChanged);
            // 
            // smallcheck
            // 
            this.smallcheck.AutoSize = true;
            this.smallcheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.smallcheck.Location = new System.Drawing.Point(45, 200);
            this.smallcheck.Name = "smallcheck";
            this.smallcheck.Size = new System.Drawing.Size(173, 20);
            this.smallcheck.TabIndex = 29;
            this.smallcheck.Text = "File più piccoli o di 50 Kb";
            this.smallcheck.UseVisualStyleBackColor = true;
            this.smallcheck.Visible = false;
            this.smallcheck.CheckedChanged += new System.EventHandler(this.smallcheck_CheckedChanged);
            // 
            // smallMedcheck
            // 
            this.smallMedcheck.AutoSize = true;
            this.smallMedcheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.smallMedcheck.Location = new System.Drawing.Point(45, 227);
            this.smallMedcheck.Name = "smallMedcheck";
            this.smallMedcheck.Size = new System.Drawing.Size(339, 20);
            this.smallMedcheck.TabIndex = 30;
            this.smallMedcheck.Text = "File più grandi di 50 Kb e più piccoli o uguali a 500 Kb";
            this.smallMedcheck.UseVisualStyleBackColor = true;
            this.smallMedcheck.Visible = false;
            this.smallMedcheck.CheckedChanged += new System.EventHandler(this.smallMedcheck_CheckedChanged);
            // 
            // mediumcheck
            // 
            this.mediumcheck.AutoSize = true;
            this.mediumcheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.mediumcheck.Location = new System.Drawing.Point(45, 253);
            this.mediumcheck.Name = "mediumcheck";
            this.mediumcheck.Size = new System.Drawing.Size(335, 20);
            this.mediumcheck.TabIndex = 31;
            this.mediumcheck.Text = "File più grandi di 500 Kb e più piccoli o uguali a 1 Mb";
            this.mediumcheck.UseVisualStyleBackColor = true;
            this.mediumcheck.Visible = false;
            this.mediumcheck.CheckedChanged += new System.EventHandler(this.mediumcheck_CheckedChanged);
            // 
            // medbigcheck
            // 
            this.medbigcheck.AutoSize = true;
            this.medbigcheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.medbigcheck.Location = new System.Drawing.Point(45, 282);
            this.medbigcheck.Name = "medbigcheck";
            this.medbigcheck.Size = new System.Drawing.Size(331, 20);
            this.medbigcheck.TabIndex = 32;
            this.medbigcheck.Text = "File più grandi di 1 Mb e più piccoli o uguali a 10 Mb";
            this.medbigcheck.UseVisualStyleBackColor = true;
            this.medbigcheck.Visible = false;
            this.medbigcheck.CheckedChanged += new System.EventHandler(this.medbigcheck_CheckedChanged);
            // 
            // bigcgeck
            // 
            this.bigcgeck.AutoSize = true;
            this.bigcgeck.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.bigcgeck.Location = new System.Drawing.Point(45, 308);
            this.bigcgeck.Name = "bigcgeck";
            this.bigcgeck.Size = new System.Drawing.Size(345, 20);
            this.bigcgeck.TabIndex = 33;
            this.bigcgeck.Text = "File più grandi di 10 Mb e più piccoli o uguali a 100 Mb";
            this.bigcgeck.UseVisualStyleBackColor = true;
            this.bigcgeck.Visible = false;
            this.bigcgeck.CheckedChanged += new System.EventHandler(this.bigcgeck_CheckedChanged);
            // 
            // hugecheck
            // 
            this.hugecheck.AutoSize = true;
            this.hugecheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.hugecheck.Location = new System.Drawing.Point(45, 334);
            this.hugecheck.Name = "hugecheck";
            this.hugecheck.Size = new System.Drawing.Size(337, 20);
            this.hugecheck.TabIndex = 34;
            this.hugecheck.Text = "File più grandi di 100 Mb e più piccoli o uguali a 2 Gb";
            this.hugecheck.UseVisualStyleBackColor = true;
            this.hugecheck.Visible = false;
            this.hugecheck.CheckedChanged += new System.EventHandler(this.hugecheck_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 516);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 13);
            this.label1.TabIndex = 35;
            this.label1.Text = "Le sottocartelle saranno create automaticamente.";
            // 
            // megacheck
            // 
            this.megacheck.AutoSize = true;
            this.megacheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.megacheck.Location = new System.Drawing.Point(45, 361);
            this.megacheck.Name = "megacheck";
            this.megacheck.Size = new System.Drawing.Size(159, 20);
            this.megacheck.TabIndex = 36;
            this.megacheck.Text = "File più grandi di 2 Gb ";
            this.megacheck.UseVisualStyleBackColor = true;
            this.megacheck.Visible = false;
            this.megacheck.CheckedChanged += new System.EventHandler(this.megacheck_CheckedChanged);
            // 
            // shortFoldersCheck
            // 
            this.shortFoldersCheck.AutoSize = true;
            this.shortFoldersCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.shortFoldersCheck.Location = new System.Drawing.Point(45, 387);
            this.shortFoldersCheck.Name = "shortFoldersCheck";
            this.shortFoldersCheck.Size = new System.Drawing.Size(201, 20);
            this.shortFoldersCheck.TabIndex = 37;
            this.shortFoldersCheck.Text = "Usa nomi brevi per le cartelle";
            this.shortFoldersCheck.UseVisualStyleBackColor = true;
            this.shortFoldersCheck.Visible = false;
            this.shortFoldersCheck.CheckedChanged += new System.EventHandler(this.shortFoldersCheck_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(894, 611);
            this.Controls.Add(this.shortFoldersCheck);
            this.Controls.Add(this.megacheck);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.hugecheck);
            this.Controls.Add(this.bigcgeck);
            this.Controls.Add(this.medbigcheck);
            this.Controls.Add(this.mediumcheck);
            this.Controls.Add(this.smallMedcheck);
            this.Controls.Add(this.smallcheck);
            this.Controls.Add(this.AltroBox);
            this.Controls.Add(this.exeBox);
            this.Controls.Add(this.MusicaBox);
            this.Controls.Add(this.ArchiviBox);
            this.Controls.Add(this.VideoBox);
            this.Controls.Add(this.ImageBox);
            this.Controls.Add(this.DocumentiBox);
            this.Controls.Add(this.Progress);
            this.Controls.Add(this.StopButton);
            this.Controls.Add(this.Everylabel2);
            this.Controls.Add(this.RepeatValue);
            this.Controls.Add(this.Repeat);
            this.Controls.Add(this.Everylabel);
            this.Controls.Add(this.AvviaButton);
            this.Controls.Add(this.tempoannoradio);
            this.Controls.Add(this.tempomeseradio);
            this.Controls.Add(this.destlabel);
            this.Controls.Add(this.sfogliadest);
            this.Controls.Add(this.DestText);
            this.Controls.Add(this.tut1);
            this.Controls.Add(this.ComboMetodo);
            this.Controls.Add(this.SmistaAsk);
            this.Controls.Add(this.delPulsante);
            this.Controls.Add(this.SfogliaSource);
            this.Controls.Add(this.SourceText);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Smistamento File";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RepeatValue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker SmistamentoDataWorker;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem esciToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem informazioniToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem infoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aiutoToolStripMenuItem;
        private System.Windows.Forms.TextBox SourceText;
        private System.Windows.Forms.Button SfogliaSource;
        private System.Windows.Forms.Button delPulsante;
        private System.Windows.Forms.Label SmistaAsk;
        private System.Windows.Forms.ComboBox ComboMetodo;
        private System.Windows.Forms.Label tut1;
        private System.Windows.Forms.TextBox DestText;
        private System.Windows.Forms.Button sfogliadest;
        private System.Windows.Forms.Label destlabel;
        private System.Windows.Forms.RadioButton tempomeseradio;
        private System.Windows.Forms.RadioButton tempoannoradio;
        private System.Windows.Forms.Label tempotooltip;
        private System.Windows.Forms.Button AvviaButton;
        private System.Windows.Forms.Label Everylabel;
        private System.Windows.Forms.CheckBox Repeat;
        private System.Windows.Forms.NumericUpDown RepeatValue;
        private System.Windows.Forms.Label Everylabel2;
        private System.Windows.Forms.Button StopButton;
        private System.Windows.Forms.ProgressBar Progress;
        private System.Windows.Forms.CheckBox DocumentiBox;
        private System.Windows.Forms.CheckBox ImageBox;
        private System.Windows.Forms.CheckBox VideoBox;
        private System.Windows.Forms.CheckBox ArchiviBox;
        private System.Windows.Forms.CheckBox MusicaBox;
        private System.Windows.Forms.CheckBox exeBox;
        private System.Windows.Forms.CheckBox AltroBox;
        private System.Windows.Forms.CheckBox smallcheck;
        private System.Windows.Forms.CheckBox smallMedcheck;
        private System.Windows.Forms.CheckBox mediumcheck;
        private System.Windows.Forms.CheckBox medbigcheck;
        private System.Windows.Forms.CheckBox bigcgeck;
        private System.Windows.Forms.CheckBox hugecheck;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox megacheck;
        private System.Windows.Forms.CheckBox shortFoldersCheck;
    }
}

