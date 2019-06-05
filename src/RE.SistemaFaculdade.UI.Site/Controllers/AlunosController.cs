using System;
using System.Net;
using System.Web.Mvc;
using RE.SistemaFaculdade.Application;
using RE.SistemaFaculdade.Application.ViewModels;


namespace RE.SistemaFaculdade.UI.Site.Controllers
{
    public class AlunosController : Controller
    {
        private readonly AlunoAppService _alunoAppService;

        public AlunosController()
        {
            _alunoAppService = new AlunoAppService();
        }

        // GET: Alunos
        public ActionResult Index()
        {
            return View(_alunoAppService.ObterTodos());
        }

        // GET: Alunos/Details/5
        public ActionResult Details(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            var alunoViewModel = _alunoAppService.ObterPorId(id.Value);

            if (alunoViewModel == null)
            {
                return HttpNotFound();
            }
            return View(alunoViewModel);
        }

        // GET: Alunos/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Alunos/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        //public ActionResult Create([Bind(Include = "AlunoId,Nome,Tel,Email,DataCadastro,Ativo")] AlunoViewModel alunoViewModel)
        public ActionResult Create(ALCACFPViewModel aLCACFPViewModel)
        {
            if (ModelState.IsValid)
            {
                _alunoAppService.Adicionar(aLCACFPViewModel);
                return RedirectToAction("Index");
            }

            return View(aLCACFPViewModel);
        }

        // GET: Alunos/Edit/5
        public ActionResult Edit(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var alunoViewModel = _alunoAppService.ObterPorId(id.Value);

            if (alunoViewModel == null)
            {
                return HttpNotFound();
            }
            return View(alunoViewModel);
        }




        // POST: Alunos/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(AlunoViewModel alunoViewModel)
        {
            if (ModelState.IsValid)
            {
                _alunoAppService.Atualizar(alunoViewModel);
                return RedirectToAction("Index");
            }
            return View(alunoViewModel);
        }



        // GET: Alunos/Delete/5
        public ActionResult Delete(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var alunoViewModel = _alunoAppService.ObterPorId(id.Value);

            if (alunoViewModel == null)
            {
                return HttpNotFound();
            }
            return View(alunoViewModel);
        }

        // POST: Alunos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(Guid id)
        {
            _alunoAppService.Remover(id);
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _alunoAppService.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
