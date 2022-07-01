using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrabalhoWindowsForm
{
    public partial class HistoricoCompraForm : Form
    {
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn ColumnCliente;
        private DataGridViewTextBoxColumn ColumnCarro;
        private DataGridViewTextBoxColumn ColumnParcelas;
        private DataGridViewTextBoxColumn ColumnDiaPagamento;

        private SetorPagamentoForm setorPagamento;
        private ClientesForm clientes;
        private CadastroCarrosForm cadastroCarros;
        public HistoricoCompraForm()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ColumnCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCarro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnParcelas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDiaPagamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnCliente,
            this.ColumnCarro,
            this.ColumnParcelas,
            this.ColumnDiaPagamento});
            this.dataGridView1.Location = new System.Drawing.Point(12, 18);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(443, 353);
            this.dataGridView1.TabIndex = 1;
            // 
            // ColumnCliente
            // 
            this.ColumnCliente.HeaderText = "Cliente";
            this.ColumnCliente.Name = "ColumnCliente";
            this.ColumnCliente.ReadOnly = true;
            // 
            // ColumnCarro
            // 
            this.ColumnCarro.HeaderText = "Carro";
            this.ColumnCarro.Name = "ColumnCarro";
            this.ColumnCarro.ReadOnly = true;
            // 
            // ColumnParcelas
            // 
            this.ColumnParcelas.HeaderText = "Parcelas";
            this.ColumnParcelas.Name = "ColumnParcelas";
            this.ColumnParcelas.ReadOnly = true;
            // 
            // ColumnDiaPagamento
            // 
            this.ColumnDiaPagamento.HeaderText = "Dia do pagamento";
            this.ColumnDiaPagamento.Name = "ColumnDiaPagamento";
            this.ColumnDiaPagamento.ReadOnly = true;
            // 
            // HistoricoCompraForm
            // 
            this.ClientSize = new System.Drawing.Size(830, 383);
            this.Controls.Add(this.dataGridView1);
            this.Name = "HistoricoCompraForm";
            this.Text = "Histórico de Compra";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        private void ApresentarInformacoes()
        {
            clientes.
        }

    }
}