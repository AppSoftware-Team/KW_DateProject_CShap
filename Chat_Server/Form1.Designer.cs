﻿namespace ChatServer
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
            this.txt_all = new System.Windows.Forms.TextBox();
            this.txt_send = new System.Windows.Forms.TextBox();
            this.txt_serverPort = new System.Windows.Forms.TextBox();
            this.txt_serverIP = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_send = new System.Windows.Forms.Button();
            this.btn_serverStart = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_all
            // 
            this.txt_all.Location = new System.Drawing.Point(21, 23);
            this.txt_all.Multiline = true;
            this.txt_all.Name = "txt_all";
            this.txt_all.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_all.Size = new System.Drawing.Size(408, 303);
            this.txt_all.TabIndex = 1;
            // 
            // txt_send
            // 
            this.txt_send.Location = new System.Drawing.Point(21, 345);
            this.txt_send.Name = "txt_send";
            this.txt_send.Size = new System.Drawing.Size(408, 25);
            this.txt_send.TabIndex = 6;
            this.txt_send.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_send_KeyDown);
            // 
            // txt_serverPort
            // 
            this.txt_serverPort.Location = new System.Drawing.Point(457, 131);
            this.txt_serverPort.Name = "txt_serverPort";
            this.txt_serverPort.Size = new System.Drawing.Size(136, 25);
            this.txt_serverPort.TabIndex = 10;
            // 
            // txt_serverIP
            // 
            this.txt_serverIP.Location = new System.Drawing.Point(457, 54);
            this.txt_serverIP.Name = "txt_serverIP";
            this.txt_serverIP.Size = new System.Drawing.Size(136, 25);
            this.txt_serverIP.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(454, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "Port Number :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(454, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "IP Address :";
            // 
            // btn_send
            // 
            this.btn_send.Location = new System.Drawing.Point(457, 345);
            this.btn_send.Name = "btn_send";
            this.btn_send.Size = new System.Drawing.Size(84, 25);
            this.btn_send.TabIndex = 11;
            this.btn_send.Text = "보내기";
            this.btn_send.UseVisualStyleBackColor = true;
            this.btn_send.Click += new System.EventHandler(this.btn_send_Click);
            // 
            // btn_serverStart
            // 
            this.btn_serverStart.Location = new System.Drawing.Point(457, 185);
            this.btn_serverStart.Name = "btn_serverStart";
            this.btn_serverStart.Size = new System.Drawing.Size(136, 28);
            this.btn_serverStart.TabIndex = 12;
            this.btn_serverStart.Text = "서버 시작";
            this.btn_serverStart.UseVisualStyleBackColor = true;
            this.btn_serverStart.Click += new System.EventHandler(this.btn_serverStart_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(456, 298);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(136, 28);
            this.btn_clear.TabIndex = 13;
            this.btn_clear.Text = "지우개";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 396);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_serverStart);
            this.Controls.Add(this.btn_send);
            this.Controls.Add(this.txt_serverPort);
            this.Controls.Add(this.txt_serverIP);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_send);
            this.Controls.Add(this.txt_all);
            this.Name = "Form1";
            this.Text = "Server";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_all;
        private System.Windows.Forms.TextBox txt_send;
        private System.Windows.Forms.TextBox txt_serverPort;
        private System.Windows.Forms.TextBox txt_serverIP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_send;
        private System.Windows.Forms.Button btn_serverStart;
        private System.Windows.Forms.Button btn_clear;
    }
}

