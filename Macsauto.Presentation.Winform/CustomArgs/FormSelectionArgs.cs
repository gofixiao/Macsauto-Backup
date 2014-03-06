namespace Macsauto.Presentation.WinForm.CustomArgs
{
    using System;
    using Macsauto.Domain.Shared;

    public class FormSelectionArgs<T> : EventArgs where T : Entity
    {
        private readonly T _entity;

        public FormSelectionArgs(T entity)
        {
            _entity = entity;
        }

        public T Entity
        {
            get { return _entity; }
        }
    }
}