using System.Web.UI;

using TrabalhoAngular.Models.Cursos;

using TrabalhoAngular.Models.Alunos;

using Newtonsoft.Json;

using Newtonsoft.Json.Serialization;



namespace TrabalhoAngular.Models.Inscricoes

{

    public class InscricaoFactory

    {

        public Inscricao BuildInscricao()

        {

            var inscricao = new Inscricao

            {

                Cursos = GetSerializedCursos(),

                Alunos = GetSerializedAlunos(),

            };

            return inscricao;

        }



        public string GetSerializedCursos()

        {

            var cursos = new[]

            {

                new Curso {Codigo = "1A", Nome = "Ensinando .Net", Instrutor = "Gerson"},

                new Curso {Codigo = "2B", Nome = "Ensinando Azure", Instrutor = "Amélia"},

                new Curso {Codigo = "3C", Nome = "Ensinando Angular", Instrutor = "Asdrubal"},

            };



            JsonSerializerSettings settings = new JsonSerializerSettings { ContractResolver = new CamelCasePropertyNamesContractResolver() };



            return JsonConvert.SerializeObject(cursos, Formatting.None, settings);

        }



        public string GetSerializedAlunos()

        {

            var alunos = new[]

            {

                new Aluno {Codigo = "1", Nome = "Algum Nome", Email = "algumnome@email.com"},

                new Aluno {Codigo = "2", Nome = "Outro Nome", Email = "outronome@email.com"},

                new Aluno {Codigo = "3", Nome = "Mais Um Nome", Email = "maisumnome@email.com"},

            };



            JsonSerializerSettings settings = new JsonSerializerSettings { ContractResolver = new CamelCasePropertyNamesContractResolver() };



            return JsonConvert.SerializeObject(alunos, Formatting.None, settings);

        }

    }

}
