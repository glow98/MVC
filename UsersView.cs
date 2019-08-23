using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;
using MVC.Controller;
using MVC.Model;

namespace MVC.View
{
    public partial class UsersView : Form, IUsersView
    {
        public void SetController(UsersController controller)
        {
            _controller = controller;
        }

        public void AddUserToGrid(User usr)
        {
            ListViewItem parent;
            parent = this.grdUsers.Items.Add(usr.ID);
            parent.SubItems.Add(usr.FirstName);
            parent.SubItems.Add(usr.LastName);
            parent.SubItems.Add(usr.Department);
            parent.SubItems.Add(Enum.GetName(typeof(User.SexOfPerson), usr.Sex));
        }

        public void UpdateGridWithChangedUser(User usr)
        {
            ListViewItem rowToUpdate = null;

            foreach (ListViewItem row in this.grdUsers.Items)
            {
                if (row.Text == usr.ID)
                {
                    rowToUpdate = row;
                }
            }

            if (rowToUpdate != null)
            {
                rowToUpdate.Text = usr.ID;
                rowToUpdate.SubItems[1].Text = usr.FirstName;
                rowToUpdate.SubItems[2].Text = usr.LastName;
                rowToUpdate.SubItems[3].Text = usr.Department;
                rowToUpdate.SubItems[4].Text = Enum.GetName(typeof(User.SexOfPerson), usr.Sex);
            }
        }

        public void RemoveUserFromGrid(User usr)
        {

            ListViewItem rowToRemove = null;

            foreach (ListViewItem row in this.grdUsers.Items)
            {
                if (row.Text == usr.ID)
                {
                    rowToRemove = row;
                }
            }

            if (rowToRemove != null)
            {
                this.grdUsers.Items.Remove(rowToRemove);
                this.grdUsers.Focus();
            }
        }

        public string GetIdOfSelectedUserInGrid()
        {
            if (this.grdUsers.SelectedItems.Count > 0)
                return this.grdUsers.SelectedItems[0].Text;
            else
                return "";
        }

        public void SetSelectedUserInGrid(User usr)
        {
            foreach (ListViewItem row in this.grdUsers.Items)
            {
                if (row.Text == usr.ID)
                {
                    row.Selected = true;
                }
            }
        }

        public string FirstName
        {
            get { return this.txtFirstName.Text; }
            set { this.txtFirstName.Text = value; }
        }

        public string LastName
        {
            get { return this.txtLastName.Text; }
            set { this.txtLastName.Text = value; }
        }

        public string ID
        {
            get { return this.txtID.Text; }
            set { this.txtID.Text = value; }
        }


        public string Department
        {
            get { return this.txtDepartment.Text; }
            set { this.txtDepartment.Text = value; }
        }

        public User.SexOfPerson Sex
        {
            get
            {
                if (this.rdMale.Checked)
                    return User.SexOfPerson.Male;
                else
                    return User.SexOfPerson.Female;
            }
            set
            {
                if (value == User.SexOfPerson.Male)
                    this.rdMale.Checked = true;
                else
                    this.rdFamele.Checked = true;
            }
        }

        public bool CanModifyID
        {
            set { this.txtID.Enabled = value; }
        }




    }


}
