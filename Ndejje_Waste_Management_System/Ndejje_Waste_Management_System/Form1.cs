using System;
using System.Drawing;
using System.Windows.Forms;

namespace Ndejje_Waste_Management_System
{
    public partial class MainForm : Form
    {
        private Panel pnlSidebar, pnlContent;

        public MainForm()
        {
            InitializeComponent();
            this.Size = new Size(1000, 600);
            this.Text = "SSWMS - Ndejje Village";
            SetupLayout();
            ShowDashboard(); // Default page
        }

        private void SetupLayout()
        {
            // Sidebar with Navy Blue from your design
            pnlSidebar = new Panel { Dock = DockStyle.Left, Width = 200, BackColor = Color.FromArgb(27, 58, 107) };

            // Content area where pages swap
            pnlContent = new Panel { Dock = DockStyle.Fill, BackColor = Color.FromArgb(244, 244, 242) };

            // Sidebar Buttons
            AddNavButton("Dashboard", 80, (s, e) => ShowDashboard());
            AddNavButton("Log Collection", 130, (s, e) => ShowCollectionForm());

            this.Controls.Add(pnlContent);
            this.Controls.Add(pnlSidebar);
        }

        private void AddNavButton(string text, int y, EventHandler clickEvent)
        {
            Button btn = new Button
            {
                Text = text,
                Top = y,
                Width = 200,
                Height = 40,
                FlatStyle = FlatStyle.Flat,
                ForeColor = Color.White,
                TextAlign = ContentAlignment.MiddleCenter
            };
            btn.FlatAppearance.BorderSize = 0;
            btn.Click += clickEvent;
            pnlSidebar.Controls.Add(btn);
        }

        public void ShowDashboard() { pnlContent.Controls.Clear(); pnlContent.Controls.Add(new DashboardPage()); }
        public void ShowCollectionForm() { pnlContent.Controls.Clear(); pnlContent.Controls.Add(new CollectionPage()); }
    }
}