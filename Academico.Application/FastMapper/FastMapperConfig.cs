using FastMapper;
using Academico.Domain.Entities;

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
        }
    }
}