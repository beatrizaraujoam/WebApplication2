@Code
    ViewData("Title") = "Home Page"
End Code

<script src="https://ajax.googleapis.com/ajax/libs/jquery/3.3.1/jquery.min.js"></script>
<div class="jumbotron">
    <h1>ASP.NET</h1>
    <p class="lead">ASP.NET is a free web framework for building great Web sites and Web applications using HTML, CSS and JavaScript.</p>


</div>

<div class="row">
    <div class="col-md-4">
        <h2>Adicionar Campo</h2>

        <div id="formulario">
            <div class="form-group">
                <label>Aula: </label>
                <input type="text" name="titulo[]" placeholder="Nome da aula">
                <button type="button" id="add-campo"> + </button>
            </div>
        </div>
    </div>
    <div class="col-md-4">
        <h2>Get more libraries</h2>
        <p>NuGet is a free Visual Studio extension that makes it easy to add, remove, and update libraries and tools in Visual Studio projects.</p>
        <p><a class="btn btn-default" href="https://go.microsoft.com/fwlink/?LinkId=301866">Learn more &raquo;</a></p>
    </div>
    <div class="col-md-4">
        <h2>Web Hosting</h2>
        <p>You can easily find a web hosting company that offers the right mix of features and price for your applications.</p>
        <p><a class="btn btn-default" href="https://go.microsoft.com/fwlink/?LinkId=301867">Learn more &raquo;</a></p>
    </div>
</div>


<script>
    //https://api.jquery.com/click/
    $("#add-campo").click(function () {
        //https://api.jquery.com/append/
        $("#formulario").append('<div class="form-group"><label>Aula: </label> <input type="text" name="titulo[]" placeholder="Nome da aula"></div>');
    });
</script>