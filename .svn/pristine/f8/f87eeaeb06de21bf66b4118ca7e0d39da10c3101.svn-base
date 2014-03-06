using System;
using Macsauto.Domain.Shared;

namespace Macsauto.Presentation.WinForm
{
    public class FormTransactionSuccessArgs<T> : EventArgs where T : Entity
    {
        private readonly T _entity;
        private readonly bool _status;

        public FormTransactionSuccessArgs(T entity, bool status)
        {
            _entity = entity;
            _status = status;
        }

        public T Entity
        {
            get { return _entity; }
        }

        public bool Status
        {
            get { return _status; }
        }
    }
}