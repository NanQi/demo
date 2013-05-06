namespace LifeGame
{
   partial class FrmMain
   {
      /// <summary>
      /// Required designer variable.
      /// </summary>
      private System.ComponentModel.IContainer components = null;

      /// <summary>
      /// Clean up any resources being used.
      /// </summary>
      /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
      protected override void Dispose(bool disposing)
      {
         if (disposing && (components != null))
         {
            components.Dispose();
         }
         base.Dispose(disposing);
      }

      #region Windows Form Designer generated code

      /// <summary>
      /// Required method for Designer support - do not modify
      /// the contents of this method with the code editor.
      /// </summary>
      private void InitializeComponent()
      {
         this.components = new System.ComponentModel.Container();
         this.groupBox1 = new System.Windows.Forms.GroupBox();
         this.worldMapPanel1 = new LifeGame.WorldMapPanel();
         this.MessageListBox = new System.Windows.Forms.ListBox();
         this.groupBox2 = new System.Windows.Forms.GroupBox();
         this.button1 = new System.Windows.Forms.Button();
         this.label2 = new System.Windows.Forms.Label();
         this.txtCellCount = new System.Windows.Forms.TextBox();
         this.btnAbility = new System.Windows.Forms.Button();
         this.btnNext = new System.Windows.Forms.Button();
         this.btnStop = new System.Windows.Forms.Button();
         this.btnStart = new System.Windows.Forms.Button();
         this.btnWander = new System.Windows.Forms.Button();
         this.btnCreatePlayerCell = new System.Windows.Forms.Button();
         this.btnCreateWorld = new System.Windows.Forms.Button();
         this.groupBox3 = new System.Windows.Forms.GroupBox();
         this.lblState = new System.Windows.Forms.Label();
         this.label13 = new System.Windows.Forms.Label();
         this.lblAbility = new System.Windows.Forms.Label();
         this.label12 = new System.Windows.Forms.Label();
         this.lblVision = new System.Windows.Forms.LinkLabel();
         this.label16 = new System.Windows.Forms.Label();
         this.lblAttack = new System.Windows.Forms.Label();
         this.label18 = new System.Windows.Forms.Label();
         this.lblMaxAbilityCount = new System.Windows.Forms.Label();
         this.label7 = new System.Windows.Forms.Label();
         this.lblSpeed = new System.Windows.Forms.Label();
         this.label10 = new System.Windows.Forms.Label();
         this.lblHP = new System.Windows.Forms.Label();
         this.label5 = new System.Windows.Forms.Label();
         this.lblIntelligence = new System.Windows.Forms.Label();
         this.label8 = new System.Windows.Forms.Label();
         this.lblDexterity = new System.Windows.Forms.Label();
         this.label6 = new System.Windows.Forms.Label();
         this.lblStrength = new System.Windows.Forms.Label();
         this.label4 = new System.Windows.Forms.Label();
         this.lblEthnicity = new System.Windows.Forms.Label();
         this.label3 = new System.Windows.Forms.Label();
         this.lblNo = new System.Windows.Forms.Label();
         this.label1 = new System.Windows.Forms.Label();
         this.timer1 = new System.Windows.Forms.Timer(this.components);
         this.groupBox4 = new System.Windows.Forms.GroupBox();
         this.lblDay = new System.Windows.Forms.Label();
         this.lblTime = new System.Windows.Forms.Label();
         this.label9 = new System.Windows.Forms.Label();
         this.chbxFightMessage = new System.Windows.Forms.CheckBox();
         this.chbxAbilityMessage = new System.Windows.Forms.CheckBox();
         this.checkBox3 = new System.Windows.Forms.CheckBox();
         this.checkBox4 = new System.Windows.Forms.CheckBox();
         this.groupBox1.SuspendLayout();
         this.groupBox2.SuspendLayout();
         this.groupBox3.SuspendLayout();
         this.groupBox4.SuspendLayout();
         this.SuspendLayout();
         // 
         // groupBox1
         // 
         this.groupBox1.Controls.Add(this.worldMapPanel1);
         this.groupBox1.Location = new System.Drawing.Point(12, 12);
         this.groupBox1.Name = "groupBox1";
         this.groupBox1.Size = new System.Drawing.Size(461, 472);
         this.groupBox1.TabIndex = 0;
         this.groupBox1.TabStop = false;
         this.groupBox1.Text = "世界地图";
         // 
         // worldMapPanel1
         // 
         this.worldMapPanel1.Location = new System.Drawing.Point(10, 18);
         this.worldMapPanel1.Name = "worldMapPanel1";
         this.worldMapPanel1.SelectedCell = null;
         this.worldMapPanel1.Size = new System.Drawing.Size(441, 441);
         this.worldMapPanel1.TabIndex = 0;
         this.worldMapPanel1.SelectedCellChanged += new System.EventHandler(this.worldMapPanel1_SelectedCellChanged);
         // 
         // MessageListBox
         // 
         this.MessageListBox.FormattingEnabled = true;
         this.MessageListBox.ItemHeight = 12;
         this.MessageListBox.Location = new System.Drawing.Point(12, 490);
         this.MessageListBox.Name = "MessageListBox";
         this.MessageListBox.Size = new System.Drawing.Size(698, 100);
         this.MessageListBox.TabIndex = 1;
         // 
         // groupBox2
         // 
         this.groupBox2.Controls.Add(this.button1);
         this.groupBox2.Controls.Add(this.label2);
         this.groupBox2.Controls.Add(this.txtCellCount);
         this.groupBox2.Controls.Add(this.btnAbility);
         this.groupBox2.Controls.Add(this.btnNext);
         this.groupBox2.Controls.Add(this.btnStop);
         this.groupBox2.Controls.Add(this.btnStart);
         this.groupBox2.Controls.Add(this.btnWander);
         this.groupBox2.Controls.Add(this.btnCreatePlayerCell);
         this.groupBox2.Controls.Add(this.btnCreateWorld);
         this.groupBox2.Location = new System.Drawing.Point(479, 12);
         this.groupBox2.Name = "groupBox2";
         this.groupBox2.Size = new System.Drawing.Size(309, 133);
         this.groupBox2.TabIndex = 2;
         this.groupBox2.TabStop = false;
         this.groupBox2.Text = "上帝模式";
         // 
         // button1
         // 
         this.button1.Location = new System.Drawing.Point(148, 41);
         this.button1.Name = "button1";
         this.button1.Size = new System.Drawing.Size(75, 23);
         this.button1.TabIndex = 8;
         this.button1.Text = "击中要害";
         this.button1.UseVisualStyleBackColor = true;
         this.button1.Click += new System.EventHandler(this.button1_Click);
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.Location = new System.Drawing.Point(19, 21);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(65, 12);
         this.label2.TabIndex = 7;
         this.label2.Text = "细胞数量：";
         // 
         // txtCellCount
         // 
         this.txtCellCount.Location = new System.Drawing.Point(90, 18);
         this.txtCellCount.Name = "txtCellCount";
         this.txtCellCount.Size = new System.Drawing.Size(68, 21);
         this.txtCellCount.TabIndex = 6;
         this.txtCellCount.Text = "10";
         // 
         // btnAbility
         // 
         this.btnAbility.Location = new System.Drawing.Point(228, 41);
         this.btnAbility.Name = "btnAbility";
         this.btnAbility.Size = new System.Drawing.Size(75, 23);
         this.btnAbility.TabIndex = 5;
         this.btnAbility.Text = "奋力一击";
         this.btnAbility.UseVisualStyleBackColor = true;
         this.btnAbility.Click += new System.EventHandler(this.btnAbility_Click);
         // 
         // btnNext
         // 
         this.btnNext.Location = new System.Drawing.Point(228, 99);
         this.btnNext.Name = "btnNext";
         this.btnNext.Size = new System.Drawing.Size(75, 23);
         this.btnNext.TabIndex = 4;
         this.btnNext.Text = "下一步";
         this.btnNext.UseVisualStyleBackColor = true;
         this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
         // 
         // btnStop
         // 
         this.btnStop.Location = new System.Drawing.Point(147, 99);
         this.btnStop.Name = "btnStop";
         this.btnStop.Size = new System.Drawing.Size(75, 23);
         this.btnStop.TabIndex = 3;
         this.btnStop.Text = "暂停";
         this.btnStop.UseVisualStyleBackColor = true;
         this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
         // 
         // btnStart
         // 
         this.btnStart.Location = new System.Drawing.Point(66, 99);
         this.btnStart.Name = "btnStart";
         this.btnStart.Size = new System.Drawing.Size(75, 23);
         this.btnStart.TabIndex = 2;
         this.btnStart.Text = "开始";
         this.btnStart.UseVisualStyleBackColor = true;
         this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
         // 
         // btnWander
         // 
         this.btnWander.Location = new System.Drawing.Point(228, 70);
         this.btnWander.Name = "btnWander";
         this.btnWander.Size = new System.Drawing.Size(75, 23);
         this.btnWander.TabIndex = 1;
         this.btnWander.Text = "Wander";
         this.btnWander.UseVisualStyleBackColor = true;
         this.btnWander.Click += new System.EventHandler(this.btnWander_Click);
         // 
         // btnCreatePlayerCell
         // 
         this.btnCreatePlayerCell.Location = new System.Drawing.Point(147, 70);
         this.btnCreatePlayerCell.Name = "btnCreatePlayerCell";
         this.btnCreatePlayerCell.Size = new System.Drawing.Size(75, 23);
         this.btnCreatePlayerCell.TabIndex = 0;
         this.btnCreatePlayerCell.Text = "创造细胞";
         this.btnCreatePlayerCell.UseVisualStyleBackColor = true;
         this.btnCreatePlayerCell.Click += new System.EventHandler(this.btnCreatePlayerCell_Click);
         // 
         // btnCreateWorld
         // 
         this.btnCreateWorld.Location = new System.Drawing.Point(166, 16);
         this.btnCreateWorld.Name = "btnCreateWorld";
         this.btnCreateWorld.Size = new System.Drawing.Size(75, 23);
         this.btnCreateWorld.TabIndex = 0;
         this.btnCreateWorld.Text = "创造世界";
         this.btnCreateWorld.UseVisualStyleBackColor = true;
         this.btnCreateWorld.Click += new System.EventHandler(this.btnCreateWorld_Click);
         // 
         // groupBox3
         // 
         this.groupBox3.Controls.Add(this.lblState);
         this.groupBox3.Controls.Add(this.label13);
         this.groupBox3.Controls.Add(this.lblAbility);
         this.groupBox3.Controls.Add(this.label12);
         this.groupBox3.Controls.Add(this.lblVision);
         this.groupBox3.Controls.Add(this.label16);
         this.groupBox3.Controls.Add(this.lblAttack);
         this.groupBox3.Controls.Add(this.label18);
         this.groupBox3.Controls.Add(this.lblMaxAbilityCount);
         this.groupBox3.Controls.Add(this.label7);
         this.groupBox3.Controls.Add(this.lblSpeed);
         this.groupBox3.Controls.Add(this.label10);
         this.groupBox3.Controls.Add(this.lblHP);
         this.groupBox3.Controls.Add(this.label5);
         this.groupBox3.Controls.Add(this.lblIntelligence);
         this.groupBox3.Controls.Add(this.label8);
         this.groupBox3.Controls.Add(this.lblDexterity);
         this.groupBox3.Controls.Add(this.label6);
         this.groupBox3.Controls.Add(this.lblStrength);
         this.groupBox3.Controls.Add(this.label4);
         this.groupBox3.Controls.Add(this.lblEthnicity);
         this.groupBox3.Controls.Add(this.label3);
         this.groupBox3.Controls.Add(this.lblNo);
         this.groupBox3.Controls.Add(this.label1);
         this.groupBox3.Location = new System.Drawing.Point(479, 251);
         this.groupBox3.Name = "groupBox3";
         this.groupBox3.Size = new System.Drawing.Size(309, 233);
         this.groupBox3.TabIndex = 3;
         this.groupBox3.TabStop = false;
         this.groupBox3.Text = "细胞信息";
         // 
         // lblState
         // 
         this.lblState.AutoSize = true;
         this.lblState.Location = new System.Drawing.Point(71, 173);
         this.lblState.Name = "lblState";
         this.lblState.Size = new System.Drawing.Size(11, 12);
         this.lblState.TabIndex = 28;
         this.lblState.Text = "-";
         // 
         // label13
         // 
         this.label13.AutoSize = true;
         this.label13.Location = new System.Drawing.Point(24, 173);
         this.label13.Name = "label13";
         this.label13.Size = new System.Drawing.Size(41, 12);
         this.label13.TabIndex = 27;
         this.label13.Text = "状态：";
         // 
         // lblAbility
         // 
         this.lblAbility.AutoSize = true;
         this.lblAbility.Location = new System.Drawing.Point(71, 196);
         this.lblAbility.Name = "lblAbility";
         this.lblAbility.Size = new System.Drawing.Size(11, 12);
         this.lblAbility.TabIndex = 26;
         this.lblAbility.Text = "-";
         // 
         // label12
         // 
         this.label12.AutoSize = true;
         this.label12.Location = new System.Drawing.Point(24, 196);
         this.label12.Name = "label12";
         this.label12.Size = new System.Drawing.Size(41, 12);
         this.label12.TabIndex = 25;
         this.label12.Text = "能力：";
         // 
         // lblVision
         // 
         this.lblVision.AutoSize = true;
         this.lblVision.Location = new System.Drawing.Point(252, 114);
         this.lblVision.Name = "lblVision";
         this.lblVision.Size = new System.Drawing.Size(11, 12);
         this.lblVision.TabIndex = 24;
         this.lblVision.TabStop = true;
         this.lblVision.Text = "-";
         this.lblVision.Click += new System.EventHandler(this.lblVision_Click);
         // 
         // label16
         // 
         this.label16.AutoSize = true;
         this.label16.Location = new System.Drawing.Point(205, 114);
         this.label16.Name = "label16";
         this.label16.Size = new System.Drawing.Size(41, 12);
         this.label16.TabIndex = 20;
         this.label16.Text = "视野：";
         // 
         // lblAttack
         // 
         this.lblAttack.AutoSize = true;
         this.lblAttack.Location = new System.Drawing.Point(252, 92);
         this.lblAttack.Name = "lblAttack";
         this.lblAttack.Size = new System.Drawing.Size(11, 12);
         this.lblAttack.TabIndex = 19;
         this.lblAttack.Text = "-";
         // 
         // label18
         // 
         this.label18.AutoSize = true;
         this.label18.Location = new System.Drawing.Point(205, 92);
         this.label18.Name = "label18";
         this.label18.Size = new System.Drawing.Size(41, 12);
         this.label18.TabIndex = 18;
         this.label18.Text = "攻击：";
         // 
         // lblMaxAbilityCount
         // 
         this.lblMaxAbilityCount.AutoSize = true;
         this.lblMaxAbilityCount.Location = new System.Drawing.Point(212, 136);
         this.lblMaxAbilityCount.Name = "lblMaxAbilityCount";
         this.lblMaxAbilityCount.Size = new System.Drawing.Size(11, 12);
         this.lblMaxAbilityCount.TabIndex = 17;
         this.lblMaxAbilityCount.Text = "-";
         // 
         // label7
         // 
         this.label7.AutoSize = true;
         this.label7.Location = new System.Drawing.Point(117, 136);
         this.label7.Name = "label7";
         this.label7.Size = new System.Drawing.Size(89, 12);
         this.label7.TabIndex = 16;
         this.label7.Text = "最大能力数量：";
         // 
         // lblSpeed
         // 
         this.lblSpeed.AutoSize = true;
         this.lblSpeed.Location = new System.Drawing.Point(164, 114);
         this.lblSpeed.Name = "lblSpeed";
         this.lblSpeed.Size = new System.Drawing.Size(11, 12);
         this.lblSpeed.TabIndex = 15;
         this.lblSpeed.Text = "-";
         // 
         // label10
         // 
         this.label10.AutoSize = true;
         this.label10.Location = new System.Drawing.Point(117, 114);
         this.label10.Name = "label10";
         this.label10.Size = new System.Drawing.Size(41, 12);
         this.label10.TabIndex = 14;
         this.label10.Text = "速度：";
         // 
         // lblHP
         // 
         this.lblHP.AutoSize = true;
         this.lblHP.Location = new System.Drawing.Point(164, 92);
         this.lblHP.Name = "lblHP";
         this.lblHP.Size = new System.Drawing.Size(11, 12);
         this.lblHP.TabIndex = 11;
         this.lblHP.Text = "-";
         // 
         // label5
         // 
         this.label5.AutoSize = true;
         this.label5.Location = new System.Drawing.Point(117, 92);
         this.label5.Name = "label5";
         this.label5.Size = new System.Drawing.Size(41, 12);
         this.label5.TabIndex = 10;
         this.label5.Text = "血量：";
         // 
         // lblIntelligence
         // 
         this.lblIntelligence.AutoSize = true;
         this.lblIntelligence.Location = new System.Drawing.Point(71, 136);
         this.lblIntelligence.Name = "lblIntelligence";
         this.lblIntelligence.Size = new System.Drawing.Size(11, 12);
         this.lblIntelligence.TabIndex = 9;
         this.lblIntelligence.Text = "-";
         // 
         // label8
         // 
         this.label8.AutoSize = true;
         this.label8.Location = new System.Drawing.Point(24, 136);
         this.label8.Name = "label8";
         this.label8.Size = new System.Drawing.Size(41, 12);
         this.label8.TabIndex = 8;
         this.label8.Text = "智力：";
         // 
         // lblDexterity
         // 
         this.lblDexterity.AutoSize = true;
         this.lblDexterity.Location = new System.Drawing.Point(71, 114);
         this.lblDexterity.Name = "lblDexterity";
         this.lblDexterity.Size = new System.Drawing.Size(11, 12);
         this.lblDexterity.TabIndex = 7;
         this.lblDexterity.Text = "-";
         // 
         // label6
         // 
         this.label6.AutoSize = true;
         this.label6.Location = new System.Drawing.Point(24, 114);
         this.label6.Name = "label6";
         this.label6.Size = new System.Drawing.Size(41, 12);
         this.label6.TabIndex = 6;
         this.label6.Text = "敏捷：";
         // 
         // lblStrength
         // 
         this.lblStrength.AutoSize = true;
         this.lblStrength.Location = new System.Drawing.Point(71, 92);
         this.lblStrength.Name = "lblStrength";
         this.lblStrength.Size = new System.Drawing.Size(11, 12);
         this.lblStrength.TabIndex = 5;
         this.lblStrength.Text = "-";
         // 
         // label4
         // 
         this.label4.AutoSize = true;
         this.label4.Location = new System.Drawing.Point(24, 92);
         this.label4.Name = "label4";
         this.label4.Size = new System.Drawing.Size(41, 12);
         this.label4.TabIndex = 4;
         this.label4.Text = "力量：";
         // 
         // lblEthnicity
         // 
         this.lblEthnicity.AutoSize = true;
         this.lblEthnicity.Location = new System.Drawing.Point(71, 56);
         this.lblEthnicity.Name = "lblEthnicity";
         this.lblEthnicity.Size = new System.Drawing.Size(11, 12);
         this.lblEthnicity.TabIndex = 3;
         this.lblEthnicity.Text = "-";
         // 
         // label3
         // 
         this.label3.AutoSize = true;
         this.label3.Location = new System.Drawing.Point(24, 56);
         this.label3.Name = "label3";
         this.label3.Size = new System.Drawing.Size(41, 12);
         this.label3.TabIndex = 2;
         this.label3.Text = "种族：";
         // 
         // lblNo
         // 
         this.lblNo.AutoSize = true;
         this.lblNo.Location = new System.Drawing.Point(71, 33);
         this.lblNo.Name = "lblNo";
         this.lblNo.Size = new System.Drawing.Size(11, 12);
         this.lblNo.TabIndex = 1;
         this.lblNo.Text = "-";
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Location = new System.Drawing.Point(24, 33);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(41, 12);
         this.label1.TabIndex = 0;
         this.label1.Text = "编号：";
         // 
         // timer1
         // 
         this.timer1.Interval = 1000;
         this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
         // 
         // groupBox4
         // 
         this.groupBox4.Controls.Add(this.lblDay);
         this.groupBox4.Controls.Add(this.lblTime);
         this.groupBox4.Controls.Add(this.label9);
         this.groupBox4.Location = new System.Drawing.Point(479, 151);
         this.groupBox4.Name = "groupBox4";
         this.groupBox4.Size = new System.Drawing.Size(309, 94);
         this.groupBox4.TabIndex = 4;
         this.groupBox4.TabStop = false;
         this.groupBox4.Text = "游戏信息";
         // 
         // lblDay
         // 
         this.lblDay.AutoSize = true;
         this.lblDay.Location = new System.Drawing.Point(205, 29);
         this.lblDay.Name = "lblDay";
         this.lblDay.Size = new System.Drawing.Size(11, 12);
         this.lblDay.TabIndex = 2;
         this.lblDay.Text = "-";
         // 
         // lblTime
         // 
         this.lblTime.AutoSize = true;
         this.lblTime.Location = new System.Drawing.Point(71, 29);
         this.lblTime.Name = "lblTime";
         this.lblTime.Size = new System.Drawing.Size(11, 12);
         this.lblTime.TabIndex = 1;
         this.lblTime.Text = "-";
         // 
         // label9
         // 
         this.label9.AutoSize = true;
         this.label9.Location = new System.Drawing.Point(24, 29);
         this.label9.Name = "label9";
         this.label9.Size = new System.Drawing.Size(41, 12);
         this.label9.TabIndex = 0;
         this.label9.Text = "时间：";
         // 
         // chbxFightMessage
         // 
         this.chbxFightMessage.AutoSize = true;
         this.chbxFightMessage.Checked = true;
         this.chbxFightMessage.CheckState = System.Windows.Forms.CheckState.Checked;
         this.chbxFightMessage.Location = new System.Drawing.Point(716, 490);
         this.chbxFightMessage.Name = "chbxFightMessage";
         this.chbxFightMessage.Size = new System.Drawing.Size(72, 16);
         this.chbxFightMessage.TabIndex = 5;
         this.chbxFightMessage.Text = "战斗信息";
         this.chbxFightMessage.UseVisualStyleBackColor = true;
         this.chbxFightMessage.CheckedChanged += new System.EventHandler(this.chbxFightMessage_CheckedChanged);
         // 
         // chbxAbilityMessage
         // 
         this.chbxAbilityMessage.AutoSize = true;
         this.chbxAbilityMessage.Checked = true;
         this.chbxAbilityMessage.CheckState = System.Windows.Forms.CheckState.Checked;
         this.chbxAbilityMessage.Location = new System.Drawing.Point(716, 517);
         this.chbxAbilityMessage.Name = "chbxAbilityMessage";
         this.chbxAbilityMessage.Size = new System.Drawing.Size(72, 16);
         this.chbxAbilityMessage.TabIndex = 6;
         this.chbxAbilityMessage.Text = "获得技能";
         this.chbxAbilityMessage.UseVisualStyleBackColor = true;
         this.chbxAbilityMessage.CheckedChanged += new System.EventHandler(this.chbxAbilityMessage_CheckedChanged);
         // 
         // checkBox3
         // 
         this.checkBox3.AutoSize = true;
         this.checkBox3.Checked = true;
         this.checkBox3.CheckState = System.Windows.Forms.CheckState.Checked;
         this.checkBox3.Location = new System.Drawing.Point(716, 544);
         this.checkBox3.Name = "checkBox3";
         this.checkBox3.Size = new System.Drawing.Size(72, 16);
         this.checkBox3.TabIndex = 7;
         this.checkBox3.Text = "其他信息";
         this.checkBox3.UseVisualStyleBackColor = true;
         // 
         // checkBox4
         // 
         this.checkBox4.AutoSize = true;
         this.checkBox4.Checked = true;
         this.checkBox4.CheckState = System.Windows.Forms.CheckState.Checked;
         this.checkBox4.Location = new System.Drawing.Point(716, 571);
         this.checkBox4.Name = "checkBox4";
         this.checkBox4.Size = new System.Drawing.Size(72, 16);
         this.checkBox4.TabIndex = 8;
         this.checkBox4.Text = "其他信息";
         this.checkBox4.UseVisualStyleBackColor = true;
         // 
         // FrmMain
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(800, 600);
         this.Controls.Add(this.checkBox4);
         this.Controls.Add(this.checkBox3);
         this.Controls.Add(this.chbxAbilityMessage);
         this.Controls.Add(this.chbxFightMessage);
         this.Controls.Add(this.groupBox4);
         this.Controls.Add(this.groupBox3);
         this.Controls.Add(this.groupBox2);
         this.Controls.Add(this.MessageListBox);
         this.Controls.Add(this.groupBox1);
         this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
         this.MaximizeBox = false;
         this.Name = "FrmMain";
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
         this.Text = "FrmMain";
         this.groupBox1.ResumeLayout(false);
         this.groupBox2.ResumeLayout(false);
         this.groupBox2.PerformLayout();
         this.groupBox3.ResumeLayout(false);
         this.groupBox3.PerformLayout();
         this.groupBox4.ResumeLayout(false);
         this.groupBox4.PerformLayout();
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.GroupBox groupBox1;
      private WorldMapPanel worldMapPanel1;
      private System.Windows.Forms.ListBox MessageListBox;
      private System.Windows.Forms.GroupBox groupBox2;
      private System.Windows.Forms.Button btnCreateWorld;
      private System.Windows.Forms.Button btnCreatePlayerCell;
      private System.Windows.Forms.GroupBox groupBox3;
      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.Label lblNo;
      private System.Windows.Forms.Label lblEthnicity;
      private System.Windows.Forms.Label label3;
      private System.Windows.Forms.Label lblStrength;
      private System.Windows.Forms.Label label4;
      private System.Windows.Forms.Label lblIntelligence;
      private System.Windows.Forms.Label label8;
      private System.Windows.Forms.Label lblDexterity;
      private System.Windows.Forms.Label label6;
      private System.Windows.Forms.Label label5;
      private System.Windows.Forms.Label lblHP;
      private System.Windows.Forms.Label label16;
      private System.Windows.Forms.Label lblAttack;
      private System.Windows.Forms.Label label18;
      private System.Windows.Forms.Label lblMaxAbilityCount;
      private System.Windows.Forms.Label label7;
      private System.Windows.Forms.Label lblSpeed;
      private System.Windows.Forms.Label label10;
      private System.Windows.Forms.LinkLabel lblVision;
      private System.Windows.Forms.Button btnWander;
      private System.Windows.Forms.Timer timer1;
      private System.Windows.Forms.Button btnStart;
      private System.Windows.Forms.Button btnStop;
      private System.Windows.Forms.Button btnNext;
      private System.Windows.Forms.GroupBox groupBox4;
      private System.Windows.Forms.Label label9;
      private System.Windows.Forms.Label lblTime;
      private System.Windows.Forms.Label lblDay;
      private System.Windows.Forms.Button btnAbility;
      private System.Windows.Forms.TextBox txtCellCount;
      private System.Windows.Forms.Label label2;
      private System.Windows.Forms.Label lblAbility;
      private System.Windows.Forms.Label label12;
      private System.Windows.Forms.Button button1;
      private System.Windows.Forms.Label lblState;
      private System.Windows.Forms.Label label13;
      private System.Windows.Forms.CheckBox chbxFightMessage;
      private System.Windows.Forms.CheckBox chbxAbilityMessage;
      private System.Windows.Forms.CheckBox checkBox3;
      private System.Windows.Forms.CheckBox checkBox4;
   }
}