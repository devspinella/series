using System;
using System.Collections.Generic;
using System.Text;

namespace Series.Interfaces
{
    interface IRepositorio<T>
    {
        List<T> Lista();
        T RetornaPorId(int id);
        void Insere(T entidade);
        void Exclui(int iD);
        void Atualiza(int id, T entidade);
        int ProximoId();
    }
}
