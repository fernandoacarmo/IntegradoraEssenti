using Integradora.ECommerce.Magento001.MagentoService;
using Integradora.ERP.Winthor.EntityWinthor;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManutencaoMagento
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ExcluirRotulosExistentes();

            Integradora.ECommerce.Magento001.Integracao Magento = new Integradora.ECommerce.Magento001.Integracao();
            progressBar1.Style = ProgressBarStyle.Blocks;
            progressBar1.Value = 0;
            progressBar1.Step = 1;
            progressBar1.Maximum = Magento.ListaAtributosObrigatorios.Count();

            foreach (var atributo in Magento.ListaAtributosObrigatorios)
            {
                progressBar1.Increment(1);
                Application.DoEvents();

                if (((atributo.type == "select") || (atributo.type == "multiselect"))
                && (atributo.code.ToUpper() != "COUNTRY_OF_MANUFACTURE")
                && (atributo.code.ToUpper() != "STATUS")
                && (atributo.code.ToUpper() != "VISIBILITY")
                && (atributo.code.ToUpper() != "GIFT_WRAPPING_AVAILABLE")
                && (atributo.code.ToUpper() != "GIFT_MESSAGE_AVAILABLE")
                && (atributo.code.ToUpper() != "PRICE_VIEW")
                && (atributo.code.ToUpper() != "OPTIONS_CONTAINER")
                && (atributo.code.ToUpper() != "BRAND")
                && (atributo.code.ToUpper() != "PAGE_LAYOUT")
                && (atributo.code.ToUpper() != "IS_RECURRING")
                && (atributo.code.ToUpper() != "CUSTOM_DESIGN")
                && (atributo.code.ToUpper() != "TAX_CLASS_ID")
                && (atributo.code.ToUpper() != "MSRP_DISPLAY_ACTUAL_PRICE_TYPE")
                && (atributo.code.ToUpper() != "MSRP_ENABLED"))
                {
                    PCRotulo rotulo = new PCRotulo();
                    rotulo.Criadopelocliente = "S";
                    rotulo.Id = "VINHO" + atributo.code.ToUpper();
                    rotulo.Dtcadastro = DateTime.Now;

                    if (rotulo.Gravar())
                    {
                        catalogAttributeOptionEntity[] ListaOpcoes = Magento.ListarAtributaosOpcao(atributo.attribute_id);

                        foreach (var item in ListaOpcoes)
                        {
                            if ((item.value != "- Por Favor Selecione -")
                            && (!string.IsNullOrEmpty(item.value.Trim()))
                            && (item.value != "\n")
                                )
                            {
                                PCRotuloitem itemRotulo = new PCRotuloitem();
                                itemRotulo.Dtcadastro = rotulo.Dtcadastro;
                                itemRotulo.Id = rotulo.Id;
                                itemRotulo.Criadopelocliente = rotulo.Criadopelocliente;
                                itemRotulo.Descricao = item.label;
                                itemRotulo.Valor = item.value;

                                itemRotulo.Gravar();
                            }
                        }
                    }
                }

            }

            MessageBox.Show("Concluído");
        }

        private static void ExcluirRotulosExistentes()
        {
            List<PCRotuloitem> itens = PCRotuloitem.Listar("CRIADOPELOCLIENTE = 'S' AND ID LIKE 'VINHO%'");
            foreach (var item in itens)
            {
                item.Excluir();
            }

            List<PCRotulo> rotulo = PCRotulo.Listar("CRIADOPELOCLIENTE = 'S' AND ID LIKE 'VINHO%'");
            foreach (var item in rotulo)
            {
                item.Excluir();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
