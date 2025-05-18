using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManager.Domain.Entities
{
    public class Tarefa
    {
        public Tarefa(int id, string titulo, string descricao, string status, string data, string dataConclusao) { }

        public void IniciarTarefa() { }
        public void ConcluirTarefa() { }
        public void EditarTarefa() { }
        public void ApagarTarefa() { }

    }
}
