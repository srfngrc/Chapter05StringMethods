namespace Chapter05StringMethodsPROJ
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtLength = new System.Windows.Forms.TextBox();
            this.txtStartIndex = new System.Windows.Forms.TextBox();
            this.txtRemove = new System.Windows.Forms.TextBox();
            this.txtReplaceChars = new System.Windows.Forms.TextBox();
            this.txtReplaceResult = new System.Windows.Forms.TextBox();
            this.txtLastChar = new System.Windows.Forms.TextBox();
            this.txtToLower = new System.Windows.Forms.TextBox();
            this.txtToUpper = new System.Windows.Forms.TextBox();
            this.txtSearchChar = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.lblIndexOf = new System.Windows.Forms.Label();
            this.lblLastIndexOf = new System.Windows.Forms.Label();
            this.txtSearchIndex = new System.Windows.Forms.TextBox();
            this.txtLastIndexOf = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.lblSubstring = new System.Windows.Forms.Label();
            this.txtEndIndex = new System.Windows.Forms.TextBox();
            this.txtSubstringResult = new System.Windows.Forms.TextBox();
            this.txtRemoveResult = new System.Windows.Forms.TextBox();
            this.txtReplaceWith = new System.Windows.Forms.TextBox();
            this.Btn_Test = new System.Windows.Forms.Button();
            this.Btn_Close = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(27, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "String to Test";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(238, 33);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(447, 20);
            this.txtInput.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Location = new System.Drawing.Point(27, 186);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(205, 15);
            this.label6.TabIndex = 2;
            this.label6.Text = "Search for last character:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Location = new System.Drawing.Point(27, 156);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(205, 15);
            this.label5.TabIndex = 3;
            this.label5.Text = "Search for character:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Location = new System.Drawing.Point(27, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(205, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "String.ToLower():";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Location = new System.Drawing.Point(27, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(205, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "String.ToUpper():";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(27, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(205, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "String.Length";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label10
            // 
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label10.Location = new System.Drawing.Point(27, 306);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(205, 15);
            this.label10.TabIndex = 7;
            this.label10.Text = "txtInput.Replace() =:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label9.Location = new System.Drawing.Point(308, 276);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(87, 15);
            this.label9.TabIndex = 8;
            this.label9.Text = "Replace with:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label8.Location = new System.Drawing.Point(27, 246);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(205, 15);
            this.label8.TabIndex = 9;
            this.label8.Text = "txtInput.Remove() =:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label7.Location = new System.Drawing.Point(27, 216);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(205, 15);
            this.label7.TabIndex = 10;
            this.label7.Text = "Extract Substring from index:\r\n";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtLength
            // 
            this.txtLength.Location = new System.Drawing.Point(238, 61);
            this.txtLength.Name = "txtLength";
            this.txtLength.Size = new System.Drawing.Size(38, 20);
            this.txtLength.TabIndex = 11;
            // 
            // txtStartIndex
            // 
            this.txtStartIndex.Location = new System.Drawing.Point(238, 214);
            this.txtStartIndex.Name = "txtStartIndex";
            this.txtStartIndex.Size = new System.Drawing.Size(26, 20);
            this.txtStartIndex.TabIndex = 12;
            // 
            // txtRemove
            // 
            this.txtRemove.Location = new System.Drawing.Point(238, 244);
            this.txtRemove.Name = "txtRemove";
            this.txtRemove.Size = new System.Drawing.Size(78, 20);
            this.txtRemove.TabIndex = 13;
            // 
            // txtReplaceChars
            // 
            this.txtReplaceChars.Location = new System.Drawing.Point(238, 274);
            this.txtReplaceChars.Name = "txtReplaceChars";
            this.txtReplaceChars.Size = new System.Drawing.Size(61, 20);
            this.txtReplaceChars.TabIndex = 14;
            // 
            // txtReplaceResult
            // 
            this.txtReplaceResult.Location = new System.Drawing.Point(238, 304);
            this.txtReplaceResult.Name = "txtReplaceResult";
            this.txtReplaceResult.Size = new System.Drawing.Size(447, 20);
            this.txtReplaceResult.TabIndex = 15;
            // 
            // txtLastChar
            // 
            this.txtLastChar.Location = new System.Drawing.Point(238, 181);
            this.txtLastChar.Name = "txtLastChar";
            this.txtLastChar.Size = new System.Drawing.Size(26, 20);
            this.txtLastChar.TabIndex = 16;
            // 
            // txtToLower
            // 
            this.txtToLower.Location = new System.Drawing.Point(238, 126);
            this.txtToLower.Name = "txtToLower";
            this.txtToLower.Size = new System.Drawing.Size(447, 20);
            this.txtToLower.TabIndex = 17;
            // 
            // txtToUpper
            // 
            this.txtToUpper.Location = new System.Drawing.Point(238, 94);
            this.txtToUpper.Name = "txtToUpper";
            this.txtToUpper.Size = new System.Drawing.Size(447, 20);
            this.txtToUpper.TabIndex = 18;
            // 
            // txtSearchChar
            // 
            this.txtSearchChar.Location = new System.Drawing.Point(238, 154);
            this.txtSearchChar.Name = "txtSearchChar";
            this.txtSearchChar.Size = new System.Drawing.Size(26, 20);
            this.txtSearchChar.TabIndex = 19;
            // 
            // label11
            // 
            this.label11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label11.Location = new System.Drawing.Point(27, 276);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(205, 15);
            this.label11.TabIndex = 20;
            this.label11.Text = "Find:";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblIndexOf
            // 
            this.lblIndexOf.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblIndexOf.Location = new System.Drawing.Point(270, 157);
            this.lblIndexOf.Name = "lblIndexOf";
            this.lblIndexOf.Size = new System.Drawing.Size(306, 15);
            this.lblIndexOf.TabIndex = 21;
            this.lblIndexOf.Text = "txtInput.Text.IndexOf(\"v\",0) =";
            this.lblIndexOf.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblLastIndexOf
            // 
            this.lblLastIndexOf.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblLastIndexOf.Location = new System.Drawing.Point(270, 181);
            this.lblLastIndexOf.Name = "lblLastIndexOf";
            this.lblLastIndexOf.Size = new System.Drawing.Size(306, 15);
            this.lblLastIndexOf.TabIndex = 22;
            this.lblLastIndexOf.Text = "txtInput.Text.LastIndexOf(\"s\") =";
            this.lblLastIndexOf.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtSearchIndex
            // 
            this.txtSearchIndex.Location = new System.Drawing.Point(582, 156);
            this.txtSearchIndex.Name = "txtSearchIndex";
            this.txtSearchIndex.Size = new System.Drawing.Size(35, 20);
            this.txtSearchIndex.TabIndex = 23;
            // 
            // txtLastIndexOf
            // 
            this.txtLastIndexOf.Location = new System.Drawing.Point(582, 181);
            this.txtLastIndexOf.Name = "txtLastIndexOf";
            this.txtLastIndexOf.Size = new System.Drawing.Size(35, 20);
            this.txtLastIndexOf.TabIndex = 24;
            // 
            // label14
            // 
            this.label14.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label14.Location = new System.Drawing.Point(270, 213);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(134, 15);
            this.label14.TabIndex = 25;
            this.label14.Text = "for this many characters:";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblSubstring
            // 
            this.lblSubstring.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSubstring.Location = new System.Drawing.Point(442, 213);
            this.lblSubstring.Name = "lblSubstring";
            this.lblSubstring.Size = new System.Drawing.Size(160, 15);
            this.lblSubstring.TabIndex = 26;
            this.lblSubstring.Text = "txtInput.Text.Substring(18,7) =";
            this.lblSubstring.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtEndIndex
            // 
            this.txtEndIndex.Location = new System.Drawing.Point(410, 211);
            this.txtEndIndex.Name = "txtEndIndex";
            this.txtEndIndex.Size = new System.Drawing.Size(26, 20);
            this.txtEndIndex.TabIndex = 27;
            // 
            // txtSubstringResult
            // 
            this.txtSubstringResult.Location = new System.Drawing.Point(608, 211);
            this.txtSubstringResult.Name = "txtSubstringResult";
            this.txtSubstringResult.Size = new System.Drawing.Size(77, 20);
            this.txtSubstringResult.TabIndex = 28;
            // 
            // txtRemoveResult
            // 
            this.txtRemoveResult.Location = new System.Drawing.Point(322, 244);
            this.txtRemoveResult.Name = "txtRemoveResult";
            this.txtRemoveResult.Size = new System.Drawing.Size(363, 20);
            this.txtRemoveResult.TabIndex = 29;
            // 
            // txtReplaceWith
            // 
            this.txtReplaceWith.Location = new System.Drawing.Point(401, 274);
            this.txtReplaceWith.Name = "txtReplaceWith";
            this.txtReplaceWith.Size = new System.Drawing.Size(88, 20);
            this.txtReplaceWith.TabIndex = 30;
            // 
            // Btn_Test
            // 
            this.Btn_Test.Location = new System.Drawing.Point(27, 355);
            this.Btn_Test.Name = "Btn_Test";
            this.Btn_Test.Size = new System.Drawing.Size(100, 23);
            this.Btn_Test.TabIndex = 31;
            this.Btn_Test.Text = "Test";
            this.Btn_Test.UseVisualStyleBackColor = true;
            this.Btn_Test.Click += new System.EventHandler(this.Btn_Test_Click);
            // 
            // Btn_Close
            // 
            this.Btn_Close.Location = new System.Drawing.Point(618, 355);
            this.Btn_Close.Name = "Btn_Close";
            this.Btn_Close.Size = new System.Drawing.Size(92, 23);
            this.Btn_Close.TabIndex = 32;
            this.Btn_Close.Text = "Close";
            this.Btn_Close.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 406);
            this.Controls.Add(this.Btn_Close);
            this.Controls.Add(this.Btn_Test);
            this.Controls.Add(this.txtReplaceWith);
            this.Controls.Add(this.txtRemoveResult);
            this.Controls.Add(this.txtSubstringResult);
            this.Controls.Add(this.txtEndIndex);
            this.Controls.Add(this.lblSubstring);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtLastIndexOf);
            this.Controls.Add(this.txtSearchIndex);
            this.Controls.Add(this.lblLastIndexOf);
            this.Controls.Add(this.lblIndexOf);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtSearchChar);
            this.Controls.Add(this.txtToUpper);
            this.Controls.Add(this.txtToLower);
            this.Controls.Add(this.txtLastChar);
            this.Controls.Add(this.txtReplaceResult);
            this.Controls.Add(this.txtReplaceChars);
            this.Controls.Add(this.txtRemove);
            this.Controls.Add(this.txtStartIndex);
            this.Controls.Add(this.txtLength);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtLength;
        private System.Windows.Forms.TextBox txtStartIndex;
        private System.Windows.Forms.TextBox txtRemove;
        private System.Windows.Forms.TextBox txtReplaceChars;
        private System.Windows.Forms.TextBox txtReplaceResult;
        private System.Windows.Forms.TextBox txtLastChar;
        private System.Windows.Forms.TextBox txtToLower;
        private System.Windows.Forms.TextBox txtToUpper;
        private System.Windows.Forms.TextBox txtSearchChar;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblIndexOf;
        private System.Windows.Forms.Label lblLastIndexOf;
        private System.Windows.Forms.TextBox txtSearchIndex;
        private System.Windows.Forms.TextBox txtLastIndexOf;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lblSubstring;
        private System.Windows.Forms.TextBox txtEndIndex;
        private System.Windows.Forms.TextBox txtSubstringResult;
        private System.Windows.Forms.TextBox txtRemoveResult;
        private System.Windows.Forms.TextBox txtReplaceWith;
        private System.Windows.Forms.Button Btn_Test;
        private System.Windows.Forms.Button Btn_Close;
    }
}

