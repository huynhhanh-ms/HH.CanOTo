// Decompiled with JetBrains decompiler
// Type: Xtra.Utility.ViewModelBase
// Assembly: Xtra.Utility, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F0A554BF-0B1B-420F-A5E2-9214C58F15B4
// Assembly location: C:\Project\HH.CanOTo\references\CAN TRI VIET\Xtra.Utility.dll

using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq.Expressions;
using System.Reflection;

namespace Xtra.Utility
{
  public class ViewModelBase : INotifyPropertyChanged
  {
    public event PropertyChangedEventHandler PropertyChanged = delegate { };

    protected void RaisePropertyChanged(string propertyName)
    {
      this.VerifyPropertyExists(propertyName);
      this.PropertyChanged((object) this, new PropertyChangedEventArgs(propertyName));
    }

    protected void RaisePropertyChanged<T>(Expression<Func<T>> expression)
    {
      if (!(expression.Body is MemberExpression body))
        throw new ArgumentException("expression must be a property expression");
      this.RaisePropertyChanged(body.Member.Name);
    }

    [Conditional("DEBUG")]
    private void VerifyPropertyExists(string propertyName)
    {
      PropertyInfo property = this.GetType().GetProperty(propertyName);
      string message = string.Format("Property Name \"{0}\" does not exist in {1}", (object) propertyName, (object) this.GetType());
      Debug.Assert(PropertyInfo.op_Inequality(property, (PropertyInfo) null), message);
    }
  }
}
