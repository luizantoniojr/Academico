using Academico.Application.ViewModels;
using Academico.Domain.Entities;
using FastMapper;

namespace Academico.Application.FastMapper
{
    public class FastMapperConfig
    {
        public static void Initialize()
        {
            TypeAdapterConfig<AvaliacaoViewModel, Avaliacao>.NewConfig();
            TypeAdapterConfig<CursoViewModel, Curso>.NewConfig();
            TypeAdapterConfig<DiscenteViewModel, Discente>.NewConfig();
            TypeAdapterConfig<DisciplinaMatriculadaViewModel, DisciplinaMatriculada>.NewConfig();
            TypeAdapterConfig<DisciplinaViewModel, Disciplina>.NewConfig();
            TypeAdapterConfig<DocenteViewModel, Docente>.NewConfig();
            TypeAdapterConfig<FaltaViewModel, Falta>.NewConfig();
            TypeAdapterConfig<TurmaViewModel, Turma>.NewConfig();
            TypeAdapterConfig<UsuarioViewModel, Usuario>.NewConfig();

            //Custom Mapping
            //TypeAdapterConfig<CursoViewModel, Curso>
            //    .NewConfig()
            //    .MapFrom(dest => dest.Nome, scr => "Nome Curso");

            //Ignore Member
            //TypeAdapterConfig<CursoViewModel, Curso>
            //  .NewConfig()
            //  .IgnoreMember(m => m.Nome);

            //Max Depth
            //TypeAdapterConfig<CursoViewModel, Curso>
            //  .NewConfig()
            //  .MaxDepth(2);
        }
    }
}