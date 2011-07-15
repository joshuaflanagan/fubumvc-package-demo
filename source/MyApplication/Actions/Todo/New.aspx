<%@ Page Language="C#" Inherits="MyApplication.Actions.Todo.New" MasterPageFile="~/Shared/Main.master" %>
<%@ Import Namespace="MyApplication.Actions.Todo" %>

<asp:Content ContentPlaceHolderID="Content" runat="server">
    <%: this.FormFor(new CreateTodo()) %>
    <%: this.Edit(m=>m.Todo.Title) %>
    <br />
    <%: this.Edit(m => m.Todo.Notes)%>
    <br />
    <%: this.Edit(m=>m.Todo.DueDateTime) %>
    <br />
    <%: this.Edit(m=>m.Todo.HighPriority) %>
    <br />
    <% this.WriteExtensions("new-todo"); %>
    <input type="submit" title="Submit" />
    <%= this.EndForm() %>
</asp:Content>