using Lab2.DTO;
using Lab2.Repositories;
using Microsoft.Extensions.Caching.Memory;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Lab2
{
    public partial class Appointments : Form
    {
        IMemoryCache _memoryCache = new MemoryCache(new MemoryCacheOptions());
        PaginationInfo paginationInfo;
        List<AppointmentDTO> appointments;
        AppointmentRepository appointmentRepository;
        public Appointments()
        {
            InitializeComponent();
            this.Load += new EventHandler(Appointments_Load);
            appointmentRepository = new AppointmentRepository();
        }
        private void Appointments_Load(object sender, EventArgs e)
        {
            paginationInfo = new PaginationInfo { PageNumber = 1, PageSize = 8 };

            if (appointments == null)
                appointments = appointmentRepository.GetAllWithClientName();

            UpdateDataGridWithPagination();
            DataGridViewButtonColumn showColumn = new DataGridViewButtonColumn();

            showColumn.HeaderText = "";
            showColumn.Name = "Show Request";
            showColumn.Text = "Show";
            showColumn.UseColumnTextForButtonValue = true;

            dataGridView1.Columns.Add(showColumn);
            dataGridView1.CellClick +=
            new DataGridViewCellEventHandler(dataGridView1_CellClick);
        }
        private void UpdateDataGridWithPagination()
        {
            var startIndex = (paginationInfo.PageNumber - 1) * paginationInfo.PageSize;
            var displayedAppointments = _memoryCache.GetOrCreate(paginationInfo.PageNumber, entry =>
            {
                return appointments.Skip(startIndex).Take(paginationInfo.PageSize).ToList();
            }); 
            dataGridView1.DataSource = displayedAppointments;
            textBoxPage.Text = paginationInfo.PageNumber.ToString();
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex != dataGridView1.Columns["Show Request"].Index) return;
            int id = (int)dataGridView1["AppointmentId", e.RowIndex].Value;
            if (e.ColumnIndex ==
            dataGridView1.Columns["Show Request"].Index)
            {
                ShowAppointment showAppointment = new ShowAppointment(appointmentRepository, id);
                showAppointment.Show();
                this.Close();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            EditAppointment editAppointment = new EditAppointment(appointmentRepository);
            editAppointment.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var currentDate = DateTime.Now.Date;
            if (futureBox.Checked && !lastBox.Checked)
                dataGridView1.DataSource = appointmentRepository
                    .GetFilteredAppointments(new Func<AppointmentDTO, bool>[] { p => DateTime.Parse(p.Date) >= currentDate });
            else if (!futureBox.Checked && lastBox.Checked)
                dataGridView1.DataSource = appointmentRepository
                    .GetFilteredAppointments(new Func<AppointmentDTO, bool>[] { p => DateTime.Parse(p.Date) < currentDate });
            else
                dataGridView1.DataSource = appointmentRepository.GetAllWithClientName();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (earlyBox.Checked && !lastestBox.Checked)
                dataGridView1.DataSource = appointmentRepository
                    .GetAllWithClientName().OrderBy(p => p.Date).OrderBy(p => p.Time).ToList();
            else if (!earlyBox.Checked && lastestBox.Checked)
                dataGridView1.DataSource = appointmentRepository
                    .GetAllWithClientName().OrderByDescending(p => p.Date).OrderByDescending(p => p.Time).ToList();
            else
                dataGridView1.DataSource = appointmentRepository.GetAllWithClientName();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (paginationInfo.PageNumber > 1)
            {
                paginationInfo.PageNumber--;
                UpdateDataGridWithPagination();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var maxPageNumber = (int)Math.Ceiling((double)appointments.Count / paginationInfo.PageSize);
            if (paginationInfo.PageNumber < maxPageNumber)
            {
                paginationInfo.PageNumber++;
                UpdateDataGridWithPagination();
            }
        }
    }
}
