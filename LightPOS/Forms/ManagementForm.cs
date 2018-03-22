﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using NickAc.LightPOS.Backend.Objects;
using NickAc.LightPOS.Backend.Utils;
using NickAc.LightPOS.Frontend.Forms.Users;
using NickAc.ModernUIDoneRight.Objects;

namespace NickAc.LightPOS.Frontend.Forms
{
    public partial class ManagementForm : TemplateForm
    {
        public override Size MaximumSize
        {
            get => Size.Empty;
            set => base.MaximumSize = value;
        }

        public ManagementForm()
        {
            InitializeComponent();
            translationHelper1.Translate(this);
        }

        private void TilePanelReborn2_Click(object sender, EventArgs e)
        {
            if (!GlobalStorage.CurrentUser.CanModifyUsers() || !GlobalStorage.CurrentUser.CanRemoveUsers())
                return;
            this.InvokeIfRequired(Hide);
            var final = SelectUserForm.ShowUserSelectionDialog(true);
            this.InvokeIfRequired(Show);
            if (final == null) return;
            this.InvokeIfRequired(Hide);
            new Users.ModifyUserForm(UserAction.Action.ModifyUser).WithUser(final).RunInAnotherApplication();
            this.InvokeIfRequired(Show);
        }

        private void TilePanelReborn3_Click(object sender, EventArgs e)
        {
            if (!GlobalStorage.CurrentUser.CanCreateUsers()) return;
            this.InvokeIfRequired(Hide);
            new Users.ModifyUserForm().RunInAnotherApplication();
            this.InvokeIfRequired(Show);
        }

        private void TilePanelReborn1_Click(object sender, EventArgs e)
        {
            if (!GlobalStorage.CurrentUser.CanManageProducts()) return;
            this.InvokeIfRequired(Hide);
            Extensions.RunInAnotherApplication<Products.ModifyProductForm>(true);

            this.InvokeIfRequired(Show);
        }

        private void TilePanelReborn4_Click(object sender, EventArgs e)
        {
            if (!GlobalStorage.CurrentUser.CanManageProducts()) return;
            this.InvokeIfRequired(Hide);
            Extensions.RunInAnotherApplication<Products.ModifyCategoryForm>(true);
            this.InvokeIfRequired(Show);
        }
    }
}