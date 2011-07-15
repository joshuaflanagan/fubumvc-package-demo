<%@ Control Language="C#" Inherits="RemindersPackage.Partials.Todo.NewReminder" %>
<%@ Import Namespace="FubuMVC.Core.UI" %>

<div style="border: 1px solid black;">
<%: this.Edit(m=>m.RecipientEmail) %>
<br />
<%: this.Edit(m=>m.DaysBeforeDue) %>
<br />
<%: this.Edit(m=>m.NumberOfTimes) %>
</div>