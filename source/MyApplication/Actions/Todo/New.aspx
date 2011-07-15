<%@ Page Language="C#" AutoEventWireup="true" Inherits="MyApplication.Actions.Todo.New" %>
<%@ Import Namespace="MyApplication.Actions.Todo" %>
<!doctype html>
<html>
<head>
    <meta charset="utf-8" />
    <meta http-equiv="X-UA-Compatible" content="IE=edge,chrome=1">
    <title>New Todo Page</title>
</head>
<body>
    <%: this.FormFor(new CreateTodo()) %>
    <%: this.Edit(m=>m.Todo.Title) %>
    <br />
    <%: this.Edit(m => m.Todo.Notes)%>
    <br />
    <%: this.Edit(m=>m.Todo.DueDateTime) %>
    <br />
    <%: this.Edit(m=>m.Todo.HighPriority) %>
    <input type="submit" title="Submit" />
    <%= this.EndForm() %>
</body>
</html>
