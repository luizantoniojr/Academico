using Academico.Application.ViewModels;
using System;
using System.Net;
using System.Net.Http;
using System.Web.Http.Cors;
using Academico.Application.Interfaces;
using System.Web.Http;

namespace Academico.Services.WebApi.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    [RoutePrefix("api/v1/public")]
    public class CursoController : ApiController
    {
        private readonly ICursoAppService _cursoAppService;
        public CursoController(ICursoAppService cursoAppService)
        {
            _cursoAppService = cursoAppService;
        }

        [HttpPost]
        [Route("cursos")]
        public HttpResponseMessage PostCurso(CursoViewModel curso)
        {
            if (curso == null)
                return Request.CreateResponse(HttpStatusCode.BadRequest);
            try
            {
                _cursoAppService.Inserir(curso);
                return Request.CreateResponse(HttpStatusCode.Created, curso);
            }
            catch (Exception e)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, e.Message);
            }
        }
    }
}