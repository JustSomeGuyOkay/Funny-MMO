﻿using DarkUI.Controls;

namespace Intersect.Editor.Forms.Editors.Events.Event_Commands
{
    partial class EventCommandDropItem
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EventCommandDropItem));
            this.grpSpawnItem = new DarkUI.Controls.DarkGroupBox();
            this.cmbItem = new DarkUI.Controls.DarkComboBox();
            this.lblItem = new System.Windows.Forms.Label();
            this.cmbConditionType = new DarkUI.Controls.DarkComboBox();
            this.lblSpawnType = new System.Windows.Forms.Label();
            this.btnCancel = new DarkUI.Controls.DarkButton();
            this.btnSave = new DarkUI.Controls.DarkButton();
            this.grpTileSpawn = new DarkUI.Controls.DarkGroupBox();
            this.nudWarpY = new DarkUI.Controls.DarkNumericUpDown();
            this.nudWarpX = new DarkUI.Controls.DarkNumericUpDown();
            this.btnVisual = new DarkUI.Controls.DarkButton();
            this.cmbMap = new DarkUI.Controls.DarkComboBox();
            this.cmbDirection = new DarkUI.Controls.DarkComboBox();
            this.lblDir = new System.Windows.Forms.Label();
            this.lblY = new System.Windows.Forms.Label();
            this.lblMap = new System.Windows.Forms.Label();
            this.lblX = new System.Windows.Forms.Label();
            this.grpEntitySpawn = new DarkUI.Controls.DarkGroupBox();
            this.chkDirRelative = new DarkUI.Controls.DarkCheckBox();
            this.pnlSpawnLoc = new System.Windows.Forms.Panel();
            this.lblRelativeLocation = new System.Windows.Forms.Label();
            this.cmbEntities = new DarkUI.Controls.DarkComboBox();
            this.lblEntity = new System.Windows.Forms.Label();
            this.grpSpawnItem.SuspendLayout();
            this.grpTileSpawn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudWarpY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudWarpX)).BeginInit();
            this.grpEntitySpawn.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpSpawnItem
            // 
            this.grpSpawnItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.grpSpawnItem.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.grpSpawnItem.Controls.Add(this.cmbItem);
            this.grpSpawnItem.Controls.Add(this.lblItem);
            this.grpSpawnItem.Controls.Add(this.cmbConditionType);
            this.grpSpawnItem.Controls.Add(this.lblSpawnType);
            this.grpSpawnItem.Controls.Add(this.btnCancel);
            this.grpSpawnItem.Controls.Add(this.btnSave);
            this.grpSpawnItem.Controls.Add(this.grpTileSpawn);
            this.grpSpawnItem.Controls.Add(this.grpEntitySpawn);
            this.grpSpawnItem.ForeColor = System.Drawing.Color.Gainsboro;
            this.grpSpawnItem.Location = new System.Drawing.Point(3, 3);
            this.grpSpawnItem.Name = "grpSpawnItem";
            this.grpSpawnItem.Size = new System.Drawing.Size(256, 388);
            this.grpSpawnItem.TabIndex = 17;
            this.grpSpawnItem.TabStop = false;
            this.grpSpawnItem.Text = "Drop Item";
            // 
            // cmbItem
            // 
            this.cmbItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.cmbItem.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.cmbItem.BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.cmbItem.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.cmbItem.DrawDropdownHoverOutline = false;
            this.cmbItem.DrawFocusRectangle = false;
            this.cmbItem.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbItem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbItem.ForeColor = System.Drawing.Color.Gainsboro;
            this.cmbItem.FormattingEnabled = true;
            this.cmbItem.Location = new System.Drawing.Point(88, 15);
            this.cmbItem.Name = "cmbItem";
            this.cmbItem.Size = new System.Drawing.Size(157, 21);
            this.cmbItem.TabIndex = 26;
            this.cmbItem.Text = null;
            this.cmbItem.TextPadding = new System.Windows.Forms.Padding(2);
            // 
            // lblItem
            // 
            this.lblItem.AutoSize = true;
            this.lblItem.Location = new System.Drawing.Point(6, 18);
            this.lblItem.Name = "lblItem";
            this.lblItem.Size = new System.Drawing.Size(30, 13);
            this.lblItem.TabIndex = 25;
            this.lblItem.Text = "Item:";
            // 
            // cmbConditionType
            // 
            this.cmbConditionType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.cmbConditionType.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.cmbConditionType.BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.cmbConditionType.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.cmbConditionType.DrawDropdownHoverOutline = false;
            this.cmbConditionType.DrawFocusRectangle = false;
            this.cmbConditionType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbConditionType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbConditionType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbConditionType.ForeColor = System.Drawing.Color.Gainsboro;
            this.cmbConditionType.FormattingEnabled = true;
            this.cmbConditionType.Items.AddRange(new object[] {
            "Specific Tile",
            "On/Around Entity"});
            this.cmbConditionType.Location = new System.Drawing.Point(88, 44);
            this.cmbConditionType.Name = "cmbConditionType";
            this.cmbConditionType.Size = new System.Drawing.Size(157, 21);
            this.cmbConditionType.TabIndex = 22;
            this.cmbConditionType.Text = "Specific Tile";
            this.cmbConditionType.TextPadding = new System.Windows.Forms.Padding(2);
            this.cmbConditionType.SelectedIndexChanged += new System.EventHandler(this.cmbConditionType_SelectedIndexChanged);
            // 
            // lblSpawnType
            // 
            this.lblSpawnType.AutoSize = true;
            this.lblSpawnType.Location = new System.Drawing.Point(6, 47);
            this.lblSpawnType.Name = "lblSpawnType";
            this.lblSpawnType.Size = new System.Drawing.Size(70, 13);
            this.lblSpawnType.TabIndex = 21;
            this.lblSpawnType.Text = "Spawn Type:";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(90, 359);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Padding = new System.Windows.Forms.Padding(5);
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 20;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(9, 359);
            this.btnSave.Name = "btnSave";
            this.btnSave.Padding = new System.Windows.Forms.Padding(5);
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 19;
            this.btnSave.Text = "Ok";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // grpTileSpawn
            // 
            this.grpTileSpawn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.grpTileSpawn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.grpTileSpawn.Controls.Add(this.nudWarpY);
            this.grpTileSpawn.Controls.Add(this.nudWarpX);
            this.grpTileSpawn.Controls.Add(this.btnVisual);
            this.grpTileSpawn.Controls.Add(this.cmbMap);
            this.grpTileSpawn.Controls.Add(this.cmbDirection);
            this.grpTileSpawn.Controls.Add(this.lblDir);
            this.grpTileSpawn.Controls.Add(this.lblY);
            this.grpTileSpawn.Controls.Add(this.lblMap);
            this.grpTileSpawn.Controls.Add(this.lblX);
            this.grpTileSpawn.ForeColor = System.Drawing.Color.Gainsboro;
            this.grpTileSpawn.Location = new System.Drawing.Point(9, 82);
            this.grpTileSpawn.Name = "grpTileSpawn";
            this.grpTileSpawn.Size = new System.Drawing.Size(236, 168);
            this.grpTileSpawn.TabIndex = 23;
            this.grpTileSpawn.TabStop = false;
            this.grpTileSpawn.Text = "Specific Tile";
            // 
            // nudWarpY
            // 
            this.nudWarpY.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.nudWarpY.ForeColor = System.Drawing.Color.Gainsboro;
            this.nudWarpY.Location = new System.Drawing.Point(74, 73);
            this.nudWarpY.Name = "nudWarpY";
            this.nudWarpY.Size = new System.Drawing.Size(120, 20);
            this.nudWarpY.TabIndex = 34;
            this.nudWarpY.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // nudWarpX
            // 
            this.nudWarpX.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.nudWarpX.ForeColor = System.Drawing.Color.Gainsboro;
            this.nudWarpX.Location = new System.Drawing.Point(74, 46);
            this.nudWarpX.Name = "nudWarpX";
            this.nudWarpX.Size = new System.Drawing.Size(121, 20);
            this.nudWarpX.TabIndex = 33;
            this.nudWarpX.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // btnVisual
            // 
            this.btnVisual.Location = new System.Drawing.Point(40, 133);
            this.btnVisual.Name = "btnVisual";
            this.btnVisual.Padding = new System.Windows.Forms.Padding(5);
            this.btnVisual.Size = new System.Drawing.Size(155, 23);
            this.btnVisual.TabIndex = 30;
            this.btnVisual.Text = "Open Visual Interface";
            this.btnVisual.Click += new System.EventHandler(this.btnVisual_Click);
            // 
            // cmbMap
            // 
            this.cmbMap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.cmbMap.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.cmbMap.BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.cmbMap.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.cmbMap.DrawDropdownHoverOutline = false;
            this.cmbMap.DrawFocusRectangle = false;
            this.cmbMap.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbMap.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbMap.ForeColor = System.Drawing.Color.Gainsboro;
            this.cmbMap.FormattingEnabled = true;
            this.cmbMap.Items.AddRange(new object[] {
            "Retain Direction",
            "Up",
            "Down",
            "Left",
            "Right"});
            this.cmbMap.Location = new System.Drawing.Point(74, 19);
            this.cmbMap.Name = "cmbMap";
            this.cmbMap.Size = new System.Drawing.Size(121, 21);
            this.cmbMap.TabIndex = 27;
            this.cmbMap.Text = "Retain Direction";
            this.cmbMap.TextPadding = new System.Windows.Forms.Padding(2);
            // 
            // cmbDirection
            // 
            this.cmbDirection.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.cmbDirection.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.cmbDirection.BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.cmbDirection.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.cmbDirection.DrawDropdownHoverOutline = false;
            this.cmbDirection.DrawFocusRectangle = false;
            this.cmbDirection.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbDirection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDirection.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbDirection.ForeColor = System.Drawing.Color.Gainsboro;
            this.cmbDirection.FormattingEnabled = true;
            this.cmbDirection.Location = new System.Drawing.Point(74, 100);
            this.cmbDirection.Name = "cmbDirection";
            this.cmbDirection.Size = new System.Drawing.Size(121, 21);
            this.cmbDirection.TabIndex = 26;
            this.cmbDirection.Text = null;
            this.cmbDirection.TextPadding = new System.Windows.Forms.Padding(2);
            // 
            // lblDir
            // 
            this.lblDir.AutoSize = true;
            this.lblDir.Location = new System.Drawing.Point(37, 103);
            this.lblDir.Name = "lblDir";
            this.lblDir.Size = new System.Drawing.Size(23, 13);
            this.lblDir.TabIndex = 25;
            this.lblDir.Text = "Dir:";
            // 
            // lblY
            // 
            this.lblY.AutoSize = true;
            this.lblY.Location = new System.Drawing.Point(37, 76);
            this.lblY.Name = "lblY";
            this.lblY.Size = new System.Drawing.Size(17, 13);
            this.lblY.TabIndex = 24;
            this.lblY.Text = "Y:";
            // 
            // lblMap
            // 
            this.lblMap.AutoSize = true;
            this.lblMap.Location = new System.Drawing.Point(37, 22);
            this.lblMap.Name = "lblMap";
            this.lblMap.Size = new System.Drawing.Size(31, 13);
            this.lblMap.TabIndex = 22;
            this.lblMap.Text = "Map:";
            // 
            // lblX
            // 
            this.lblX.AutoSize = true;
            this.lblX.Location = new System.Drawing.Point(37, 49);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(17, 13);
            this.lblX.TabIndex = 23;
            this.lblX.Text = "X:";
            // 
            // grpEntitySpawn
            // 
            this.grpEntitySpawn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.grpEntitySpawn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.grpEntitySpawn.Controls.Add(this.chkDirRelative);
            this.grpEntitySpawn.Controls.Add(this.pnlSpawnLoc);
            this.grpEntitySpawn.Controls.Add(this.lblRelativeLocation);
            this.grpEntitySpawn.Controls.Add(this.cmbEntities);
            this.grpEntitySpawn.Controls.Add(this.lblEntity);
            this.grpEntitySpawn.ForeColor = System.Drawing.Color.Gainsboro;
            this.grpEntitySpawn.Location = new System.Drawing.Point(9, 81);
            this.grpEntitySpawn.Name = "grpEntitySpawn";
            this.grpEntitySpawn.Size = new System.Drawing.Size(236, 264);
            this.grpEntitySpawn.TabIndex = 24;
            this.grpEntitySpawn.TabStop = false;
            this.grpEntitySpawn.Text = "On/Around Entity";
            // 
            // chkDirRelative
            // 
            this.chkDirRelative.AutoSize = true;
            this.chkDirRelative.Location = new System.Drawing.Point(38, 236);
            this.chkDirRelative.Name = "chkDirRelative";
            this.chkDirRelative.Size = new System.Drawing.Size(151, 17);
            this.chkDirRelative.TabIndex = 30;
            this.chkDirRelative.Text = "Relative to Entity Direction";
            // 
            // pnlSpawnLoc
            // 
            this.pnlSpawnLoc.Location = new System.Drawing.Point(38, 69);
            this.pnlSpawnLoc.Name = "pnlSpawnLoc";
            this.pnlSpawnLoc.Size = new System.Drawing.Size(160, 160);
            this.pnlSpawnLoc.TabIndex = 29;
            this.pnlSpawnLoc.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlSpawnLoc_MouseDown);
            // 
            // lblRelativeLocation
            // 
            this.lblRelativeLocation.AutoSize = true;
            this.lblRelativeLocation.Location = new System.Drawing.Point(37, 49);
            this.lblRelativeLocation.Name = "lblRelativeLocation";
            this.lblRelativeLocation.Size = new System.Drawing.Size(93, 13);
            this.lblRelativeLocation.TabIndex = 28;
            this.lblRelativeLocation.Text = "Relative Location:";
            // 
            // cmbEntities
            // 
            this.cmbEntities.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.cmbEntities.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.cmbEntities.BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.cmbEntities.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.cmbEntities.DrawDropdownHoverOutline = false;
            this.cmbEntities.DrawFocusRectangle = false;
            this.cmbEntities.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbEntities.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEntities.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbEntities.ForeColor = System.Drawing.Color.Gainsboro;
            this.cmbEntities.FormattingEnabled = true;
            this.cmbEntities.Items.AddRange(new object[] {
            "Retain Direction",
            "Up",
            "Down",
            "Left",
            "Right"});
            this.cmbEntities.Location = new System.Drawing.Point(74, 19);
            this.cmbEntities.Name = "cmbEntities";
            this.cmbEntities.Size = new System.Drawing.Size(121, 21);
            this.cmbEntities.TabIndex = 27;
            this.cmbEntities.Text = null;
            this.cmbEntities.TextPadding = new System.Windows.Forms.Padding(2);
            // 
            // lblEntity
            // 
            this.lblEntity.AutoSize = true;
            this.lblEntity.Location = new System.Drawing.Point(37, 22);
            this.lblEntity.Name = "lblEntity";
            this.lblEntity.Size = new System.Drawing.Size(36, 13);
            this.lblEntity.TabIndex = 22;
            this.lblEntity.Text = "Entity:";
            // 
            // EventCommandDropItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.Controls.Add(this.grpSpawnItem);
            this.Name = "EventCommandDropItem";
            this.Size = new System.Drawing.Size(267, 394);
            this.grpSpawnItem.ResumeLayout(false);
            this.grpSpawnItem.PerformLayout();
            this.grpTileSpawn.ResumeLayout(false);
            this.grpTileSpawn.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudWarpY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudWarpX)).EndInit();
            this.grpEntitySpawn.ResumeLayout(false);
            this.grpEntitySpawn.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DarkGroupBox grpSpawnItem;
        private DarkButton btnCancel;
        private DarkButton btnSave;
        private DarkGroupBox grpTileSpawn;
        private DarkComboBox cmbConditionType;
        private System.Windows.Forms.Label lblSpawnType;
        private DarkButton btnVisual;
        private DarkComboBox cmbMap;
        private DarkComboBox cmbDirection;
        private System.Windows.Forms.Label lblDir;
        private System.Windows.Forms.Label lblY;
        private System.Windows.Forms.Label lblMap;
        private System.Windows.Forms.Label lblX;
        private DarkGroupBox grpEntitySpawn;
        private DarkCheckBox chkDirRelative;
        private System.Windows.Forms.Panel pnlSpawnLoc;
        private DarkComboBox cmbEntities;
        private System.Windows.Forms.Label lblEntity;
        private System.Windows.Forms.Label lblRelativeLocation;
        private DarkComboBox cmbItem;
        private System.Windows.Forms.Label lblItem;
        private DarkNumericUpDown nudWarpY;
        private DarkNumericUpDown nudWarpX;
    }
}
