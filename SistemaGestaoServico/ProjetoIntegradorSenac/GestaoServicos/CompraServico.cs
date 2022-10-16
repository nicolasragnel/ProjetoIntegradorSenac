using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace ProjetoIntegradorSenac.GestaoServicos
{
    class CompraServico
    {
        static string HidrozonioterapiaDosPes { get; set; }
        static string LimpezaDePeleProfunda { get; set; }
        static string ReflexologiaPodal { get; set; }
        static string PedicureEManicure { get; set; }
        static string SpaDasMaos { get; set; }
        static string SpaDosPes { get; set; }
        static string MassagemAntiestresse { get; set; }
        static string MassagemPedrasVulcanicas { get; set; }
        static string MassagemRelaxanteAromatica { get; set; }
        static string SlimBambu { get; set; }

        public void Servicos()
        {
            HidrozonioterapiaDosPes = "Inclui esfoliação nos pés com break tea e hidrozonioterapia";
            LimpezaDePeleProfunda = "Tem como principal objetivo remover todas as impurezas do rosto,\n como células mortas, cravos (comedões),pontinhos pretos, espinhas miliuns e, desobstruir os poros sem agressões";
            ReflexologiaPodal = "É uma terapia complementar que se utiliza da manipulação dos pés, \n através de estimulação em pontos reflexos. Trata o corpo como um todo, podendo nos ajudar tanto, fisicamente quanto mentalmente";
            PedicureEManicure = "Higienização dos pés e mãos com corte de unhas, esfoliação e hidratação, \n retirada de cutícula e em seguida se o cliente desejar as unhas serão esmaltadas";
            SpaDasMaos = "Inclui em uma massagem esfoliante, uma massagem calmante e uma hidratação com parafina";
            SpaDosPes = "Inclui uma massagem esfoliante, um escalda pés e uma hidratação com parafina";
            MassagemAntiestresse = "Massagem inicia um ritual relaxante de alongamento cervical, seguido de \n movimentos lentos e suaves na face e couro cabeludo, liberando todas as tensões nessa região";
            MassagemPedrasVulcanicas = "Pedras vulcânicas aquecidas, técnicas de massagem e óleos aromáticos \n são os ingredientes que estão na base de uma experiência única e relaxante";
            MassagemRelaxanteAromatica = "Uma combinação perfeita de aromas aliada a manobras terapêuticas, \n lhe proporcionam relaxamento e estímulo na circulação dos fluídos. Perfeita para quem quer relaxar e equilibrar corpo e mente, é realizada com um delicioso e personalizado blend de aromas";
            SlimBambu = "Associação de massagem modeladora e bambuterapia com princípios ativos que ajudam na \n ativação da circulação e potencializam os resultados. Excelente massagem para modelagem corporal";
        }
        public static void ListarServicos()
        {

            //List<String> ListaServicos = new List<String>();
            //ListaServicos.Add(HidrozonioterapiaDosPes);
            //ListaServicos.Add(LimpezaDePeleProfunda);
            //ListaServicos.Add(ReflexologiaPodal);
            //ListaServicos.Add(MassagemAntiestresse);
            //ListaServicos.Add(MassagemPedrasVulcanicas);
            //ListaServicos.Add(MassagemRelaxanteAromatica);
            //ListaServicos.Add(SpaDasMaos);
            //ListaServicos.Add(SpaDosPes);
            //ListaServicos.Add(SlimBambu);
            //ListaServicos.Add(PedicureEManicure);

            string[] servicos = new string[3];
            servicos[0] = "wdckwdcjkdwc";
            servicos[1] = "dcdwcwd";
            servicos[2] = "ddcacs";

            foreach (var servico in servicos)
            {
                Console.WriteLine(servicos);
            }
        }

    }
}
