using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;
using System.Media;

/*
    Sistema de loop onde vai contar a quantidade de votos e mostrar a quantidade de votos de cada
    menu de votos:
    °1 = chaves
    °2 = barriga
    °3 = florinda
    °4 = kiko
    °5 = chiquinha
 */

namespace Urna_Eletronica
{
    public partial class Form1 : Form
    {
        Double quantidade_votos = 0;
        Double chaves, barriga, florinda, kiko, chiquinha;
        Double voto_nulo, voto_branco;
        String total_votos, resultado_chaves, resultado_barriga, resultado_florinda, resultado_kiko, resultado_de_voto_nulo, resultado_de_voto_em_branco, resultado_chiquinha;

        private void LblCandidato_TextChanged(object sender, EventArgs e)
        {
            TxtVotos.Enabled = false;
        }

        private void Btn6_Click(object sender, EventArgs e)
        {
            TxtVotos.Text = "6";
            LblCandidato.Text = "Branco";
            PcbImagem.ImageLocation = @"https://www.justicaeleitoral.jus.br/imagens/fotos/qual-e-a-diferenca-entre-o-voto-em-branco-e-o-voto-nulo/@@streaming/image/VOTO%20BRANCO.jpg";
        }

        private void BtnCorrige_Click(object sender, EventArgs e)
        {
            TxtVotos.Text = string.Empty;
            PcbImagem.ImageLocation = @"https://i0.statig.com.br/bancodeimagens/de/yn/4a/deyn4afi6f6kadhb2d9quwblu.jpg";
            LblCandidato.Text = "Candidato";
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Btn0_Click(object sender, EventArgs e)
        {
            TxtVotos.Text = "0";
            PcbImagem.ImageLocation = @"https://down-br.img.susercontent.com/file/562b3a4ec1380c9cb8494d21a1d6259a";
            LblCandidato.Text = "Nulo";
        }

        private void BtnConfirma_Click(object sender, EventArgs e)
        {
            if (TxtVotos.Text == "")
            {
                MessageBox.Show("Nenhum candidato selecionado, por favor selecione um candidato!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (TxtVotos.Text == "0")
            {
                if (MessageBox.Show("Certeza que você vai votar nulo?", "Confirme o voto", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    voto_nulo++;
                    quantidade_votos++;
                }
                else
                {
                    TxtVotos.Text = "";
                    LblCandidato.Text = "Candidato";
                    PcbImagem.ImageLocation = @"https://i0.statig.com.br/bancodeimagens/de/yn/4a/deyn4afi6f6kadhb2d9quwblu.jpg";
                }

            }
            else if (TxtVotos.Text == "1")
            {
                if (MessageBox.Show("Certeza que você vai votar no Chaves?", "Confirme o voto", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    chaves++;
                    quantidade_votos++;
                }
                else
                {
                    TxtVotos.Text = "";
                    LblCandidato.Text = "Candidato";
                    PcbImagem.ImageLocation = @"https://i0.statig.com.br/bancodeimagens/de/yn/4a/deyn4afi6f6kadhb2d9quwblu.jpg";
                }

            }
            else if (TxtVotos.Text == "2")
            {
                if (MessageBox.Show("Certeza que você vai votar no Seu Barriga?", "Confirme o voto", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    barriga++;
                    quantidade_votos++;
                }
                else
                {
                    TxtVotos.Text = "";
                    LblCandidato.Text = "Candidato";
                    PcbImagem.ImageLocation = @"https://i0.statig.com.br/bancodeimagens/de/yn/4a/deyn4afi6f6kadhb2d9quwblu.jpg";
                }
            }
            else if (TxtVotos.Text == "3")
            {
                if (MessageBox.Show("Certeza que você vai votar na Dona Florinda?", "Confirme o voto", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    florinda++;
                    quantidade_votos++;
                }
                else
                {
                    TxtVotos.Text = "";
                    LblCandidato.Text = "Candidato";
                    PcbImagem.ImageLocation = @"https://i0.statig.com.br/bancodeimagens/de/yn/4a/deyn4afi6f6kadhb2d9quwblu.jpg";
                }
            }
            else if (TxtVotos.Text == "4")
            {
                if (MessageBox.Show("Certeza que você vai votar no Kiko?", "Confirme o voto", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    kiko++;
                    quantidade_votos++;
                }
                else
                {
                    TxtVotos.Text = "";
                    PcbImagem.ImageLocation = @"https://i0.statig.com.br/bancodeimagens/de/yn/4a/deyn4afi6f6kadhb2d9quwblu.jpg";
                    LblCandidato.Text = "Candidato";
                }
            }
            else if (TxtVotos.Text == "5")
            {
                if (MessageBox.Show("Certeza que você vai votar na Chiquinha?", "Confirme o voto", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    chiquinha++;
                    quantidade_votos++;
                }
                else
                {
                    TxtVotos.Text = "";
                    LblCandidato.Text = "Candidato";
                    PcbImagem.ImageLocation = @"https://i0.statig.com.br/bancodeimagens/de/yn/4a/deyn4afi6f6kadhb2d9quwblu.jpg";
                }
            }
            else if (TxtVotos.Text == "6")
            {
                if (MessageBox.Show("Certeza que você vai votar branco?", "Confirme o voto", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    voto_branco++;
                    quantidade_votos++;
                }
                else
                {
                    TxtVotos.Text = "";
                    LblCandidato.Text = "Candidato";
                    PcbImagem.ImageLocation = @"https://i0.statig.com.br/bancodeimagens/de/yn/4a/deyn4afi6f6kadhb2d9quwblu.jpg";
                }
            }
            if (quantidade_votos >= 10)
            {
                if (MessageBox.Show("Gostaria de ver os resultados?", "Resultado", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    resultado_chaves = Convert.ToString(chaves);
                    resultado_barriga = Convert.ToString(barriga);
                    resultado_chiquinha = Convert.ToString(chiquinha);
                    resultado_florinda = Convert.ToString(florinda);
                    resultado_kiko = Convert.ToString(kiko);
                    resultado_de_voto_em_branco = Convert.ToString(voto_branco);
                    resultado_de_voto_nulo = Convert.ToString(voto_nulo);
                    total_votos = Convert.ToString(quantidade_votos);

                    if(chaves > barriga && chaves>florinda && chaves>kiko && chaves > chiquinha)
                    {
                        MessageBox.Show("Total de votos: " + total_votos + "\nVotos Chaves: " + resultado_chaves + "\nVotos Seu Barriga: " + resultado_barriga + "\nVotos Dona Florinda: " + resultado_florinda + "\nVotos Kiko: " + resultado_kiko + "\nVotos Chiquinha: " + resultado_chiquinha + "\nVotos Nulos: " + voto_nulo + "\nVotos em Branco: " + voto_branco + "\nVencedor: Chaves", "Resultados!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }else if(barriga > chaves && barriga>florinda && barriga>kiko && barriga > chiquinha)
                    {
                        MessageBox.Show("Total de votos: " + total_votos + "\nVotos Chaves: " + resultado_chaves + "\nVotos Seu Barriga: " + resultado_barriga + "\nVotos Dona Florinda: " + resultado_florinda + "\nVotos Kiko: " + resultado_kiko + "\nVotos Chiquinha: " + resultado_chiquinha + "\nVotos Nulos: " + voto_nulo + "\nVotos em Branco: " + voto_branco + "\nVencedor: Seu Barriga", "Resultados!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }else if(florinda > chaves && florinda > barriga && florinda > kiko && florinda > chiquinha)
                    {
                        MessageBox.Show("Total de votos: " + total_votos + "\nVotos Chaves: " + resultado_chaves + "\nVotos Seu Barriga: " + resultado_barriga + "\nVotos Dona Florinda: " + resultado_florinda + "\nVotos Kiko: " + resultado_kiko + "\nVotos Chiquinha: " + resultado_chiquinha + "\nVotos Nulos: " + voto_nulo + "\nVotos em Branco: " + voto_branco + "\nVencedor: Dona Florinda", "Resultados!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }else if(kiko > chaves && kiko > barriga && kiko > florinda && kiko > chiquinha)
                    {
                        MessageBox.Show("Total de votos: " + total_votos + "\nVotos Chaves: " + resultado_chaves + "\nVotos Seu Barriga: " + resultado_barriga + "\nVotos Dona Florinda: " + resultado_florinda + "\nVotos Kiko: " + resultado_kiko + "\nVotos Chiquinha: " + resultado_chiquinha + "\nVotos Nulos: " + voto_nulo + "\nVotos em Branco: " + voto_branco + "\nVencedor: Kiko", "Resultados!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }else if(chiquinha > chaves && chiquinha>barriga && chiquinha>florinda && chiquinha > kiko)
                    {
                        MessageBox.Show("Total de votos: " + total_votos + "\nVotos Chaves: " + resultado_chaves + "\nVotos Seu Barriga: " + resultado_barriga + "\nVotos Dona Florinda: " + resultado_florinda + "\nVotos Kiko: " + resultado_kiko + "\nVotos Chiquinha: " + resultado_chiquinha + "\nVotos Nulos: " + voto_nulo + "\nVotos em Branco: " + voto_branco + "\nVencedor: Chiquinha", "Resultados!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }else if (chaves == barriga && chaves != kiko && chaves != florinda && chaves != chiquinha && barriga != kiko && barriga != florinda && barriga != chiquinha)
                    {
                        MessageBox.Show("Total de votos: " + total_votos + "\nVotos Chaves: " + resultado_chaves + "\nVotos Seu Barriga: " + resultado_barriga + "\nVotos Dona Florinda: " + resultado_florinda + "\nVotos Kiko: " + resultado_kiko + "\nVotos Chiquinha: " + resultado_chiquinha + "\nVotos Nulos: " + voto_nulo + "\nVotos em Branco: " + voto_branco + "\nVencedores: Chaves e Seu Barriga", "Resultados!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }else if(chaves == florinda && chaves != kiko && chaves != barriga && chaves != chiquinha && florinda != kiko && florinda != barriga && florinda != chiquinha)
                    {
                        MessageBox.Show("Total de votos: " + total_votos + "\nVotos Chaves: " + resultado_chaves + "\nVotos Seu Barriga: " + resultado_barriga + "\nVotos Dona Florinda: " + resultado_florinda + "\nVotos Kiko: " + resultado_kiko + "\nVotos Chiquinha: " + resultado_chiquinha + "\nVotos Nulos: " + voto_nulo + "\nVotos em Branco: " + voto_branco + "\nVencedores: Chaves e Dona Florinda", "Resultados!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }else if (chaves == kiko && chaves != barriga && chaves != florinda && chaves != chiquinha && kiko != barriga && kiko != florinda && kiko != chiquinha)
                    {
                        MessageBox.Show("Total de votos: " + total_votos + "\nVotos Chaves: " + resultado_chaves + "\nVotos Seu Barriga: " + resultado_barriga + "\nVotos Dona Florinda: " + resultado_florinda + "\nVotos Kiko: " + resultado_kiko + "\nVotos Chiquinha: " + resultado_chiquinha + "\nVotos Nulos: " + voto_nulo + "\nVotos em Branco: " + voto_branco + "\nVencedores: Chaves e Kiko", "Resultados!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }else if (chaves == chiquinha && chaves != barriga && chaves != florinda && chaves != kiko && chiquinha != barriga && chiquinha != florinda && chiquinha != kiko)
                    {
                        MessageBox.Show("Total de votos: " + total_votos + "\nVotos Chaves: " + resultado_chaves + "\nVotos Seu Barriga: " + resultado_barriga + "\nVotos Dona Florinda: " + resultado_florinda + "\nVotos Kiko: " + resultado_kiko + "\nVotos Chiquinha: " + resultado_chiquinha + "\nVotos Nulos: " + voto_nulo + "\nVotos em Branco: " + voto_branco + "\nVencedores: Chaves e Chiquinha", "Resultados!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }else if(barriga == florinda && barriga != chaves && barriga != kiko && barriga != chiquinha && florinda != chaves && florinda != kiko && florinda != chiquinha)
                    {
                        MessageBox.Show("Total de votos: " + total_votos + "\nVotos Chaves: " + resultado_chaves + "\nVotos Seu Barriga: " + resultado_barriga + "\nVotos Dona Florinda: " + resultado_florinda + "\nVotos Kiko: " + resultado_kiko + "\nVotos Chiquinha: " + resultado_chiquinha + "\nVotos Nulos: " + voto_nulo + "\nVotos em Branco: " + voto_branco + "\nVencedores: Seu Barriga e Dona Florinda", "Resultados!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }else if(barriga == kiko && barriga != chaves && barriga != florinda && barriga != chiquinha && kiko != chaves && kiko != florinda && kiko != chiquinha)
                    {
                        MessageBox.Show("Total de votos: " + total_votos + "\nVotos Chaves: " + resultado_chaves + "\nVotos Seu Barriga: " + resultado_barriga + "\nVotos Dona Florinda: " + resultado_florinda + "\nVotos Kiko: " + resultado_kiko + "\nVotos Chiquinha: " + resultado_chiquinha + "\nVotos Nulos: " + voto_nulo + "\nVotos em Branco: " + voto_branco + "\nVencedores: Seu Barriga e Kiko", "Resultados!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }else if(barriga == chiquinha && barriga != chaves && barriga != florinda && barriga != kiko && chiquinha != chaves && chiquinha != florinda && chiquinha != kiko)
                    {
                        MessageBox.Show("Total de votos: " + total_votos + "\nVotos Chaves: " + resultado_chaves + "\nVotos Seu Barriga: " + resultado_barriga + "\nVotos Dona Florinda: " + resultado_florinda + "\nVotos Kiko: " + resultado_kiko + "\nVotos Chiquinha: " + resultado_chiquinha + "\nVotos Nulos: " + voto_nulo + "\nVotos em Branco: " + voto_branco + "\nVencedores: Seu Barriga e Chiquinha", "Resultados!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }else if (florinda == kiko && florinda != chaves && florinda != barriga && florinda != chiquinha && kiko != chaves && kiko != barriga && kiko != chiquinha)
                    {
                        MessageBox.Show("Total de votos: " + total_votos + "\nVotos Chaves: " + resultado_chaves + "\nVotos Seu Barriga: " + resultado_barriga + "\nVotos Dona Florinda: " + resultado_florinda + "\nVotos Kiko: " + resultado_kiko + "\nVotos Chiquinha: " + resultado_chiquinha + "\nVotos Nulos: " + voto_nulo + "\nVotos em Branco: " + voto_branco + "\nVencedores: Dona Florinda e Kiko", "Resultados!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }else if (florinda == chiquinha && florinda != chaves && florinda != barriga && florinda != kiko && chiquinha != chaves && chiquinha != barriga && chiquinha != kiko)
                    {
                        MessageBox.Show("Total de votos: " + total_votos + "\nVotos Chaves: " + resultado_chaves + "\nVotos Seu Barriga: " + resultado_barriga + "\nVotos Dona Florinda: " + resultado_florinda + "\nVotos Kiko: " + resultado_kiko + "\nVotos Chiquinha: " + resultado_chiquinha + "\nVotos Nulos: " + voto_nulo + "\nVotos em Branco: " + voto_branco + "\nVencedores: Dona Florinda e Chiquinha", "Resultados!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }else if(kiko == chiquinha && kiko != chaves && kiko != barriga && kiko != florinda && chiquinha != chaves && chiquinha != barriga && chiquinha != florinda)
                    {
                        MessageBox.Show("Total de votos: " + total_votos + "\nVotos Chaves: " + resultado_chaves + "\nVotos Seu Barriga: " + resultado_barriga + "\nVotos Dona Florinda: " + resultado_florinda + "\nVotos Kiko: " + resultado_kiko + "\nVotos Chiquinha: " + resultado_chiquinha + "\nVotos Nulos: " + voto_nulo + "\nVotos em Branco: " + voto_branco + "\nVencedores: Kiko e Chiquinha", "Resultados!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void TxtVotos_TextChanged(object sender, EventArgs e)
        {
            TxtVotos.MaxLength = 1;
            TxtVotos.Enabled = false;
            
            
        }

        private void Btn1_Click(object sender, EventArgs e)
        {
            TxtVotos.Text = "1";
            PcbImagem.ImageLocation = @"https://upload.wikimedia.org/wikipedia/pt/b/bb/El_Chavo_Roberto_Bola%C3%B1os.png";
            LblCandidato.Text = "Chaves";
        }

        private void Btn2_Click(object sender, EventArgs e)
        {
            TxtVotos.Text = "2";
            PcbImagem.ImageLocation = @"https://upload.wikimedia.org/wikipedia/pt/9/9b/Seu_Barriga.png";
            LblCandidato.Text = "Seu Barriga";
        }

        private void Btn3_Click(object sender, EventArgs e)
        {
            TxtVotos.Text = "3";
            PcbImagem.ImageLocation = @"https://vejasp.abril.com.br/wp-content/uploads/2016/12/donaflorinda.jpg";
            LblCandidato.Text = "Dona Florinda";
        }

        private void Btn4_Click(object sender, EventArgs e)
        {
            TxtVotos.Text = "4";
            PcbImagem.ImageLocation = @"https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQXkmyehEG2IRy2_LqfI7bxLSlRu_0AhLe7ZP8-8fRc2g&s";
            LblCandidato.Text = "Kiko";
        }

        private void Btn5_Click(object sender, EventArgs e)
        {
            TxtVotos.Text = "5";
            PcbImagem.ImageLocation = @"https://static.wikia.nocookie.net/chespirito/images/e/ef/Chiquinha.png/revision/latest?cb=20180717201504&path-prefix=pt";
            LblCandidato.Text = "Chiquinha";
        }
    }
}