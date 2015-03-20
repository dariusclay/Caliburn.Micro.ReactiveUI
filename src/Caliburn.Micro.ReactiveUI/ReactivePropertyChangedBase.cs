// ReSharper disable ExplicitCallerInfoArgument
namespace Caliburn.Micro.ReactiveUI
{
    using System;
    using System.Runtime.CompilerServices;
    using global::ReactiveUI;

    public class ReactivePropertyChangedBase : ReactiveObject, INotifyPropertyChangedEx
    {
        public bool IsNotifying
        {
            get { return AreChangeNotificationsEnabled(); }
            set { throw new NotSupportedException(); }
        }

        /// <summary>
        /// Notifies subscribers of the property change.
        /// </summary>
        /// <param name = "propertyName">Name of the property.</param>
        [NotifyPropertyChangedInvocator]
        public virtual void NotifyOfPropertyChange( [CallerMemberName] string propertyName = null )
        {
            this.RaisePropertyChanged( propertyName );
        }

        public void Refresh()
        {
            NotifyOfPropertyChange( string.Empty );
        }
    }
}
