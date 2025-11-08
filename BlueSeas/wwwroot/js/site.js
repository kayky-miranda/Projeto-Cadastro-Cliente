$(document).ready(function () {
    $('#Clientes').DataTable({
        language:
        {
            "decimal": "",
            "emptyTable": "Nenhum registro encontrado.",
            "info": "Mostrando _START_ registro de _END_ em um total de _TOTAL_ entradas",
            "infoEmpty": "Mostrando 0 de 0 entradas",
            "infoFiltered": "(Filtrado _MAX_ entradas)",
            "infoPostFix": "",
            "thousands": ",",
            "lengthMenu": "Mostrar _MENU_ entradas",
            "loadingRecords": "Loading...",
            "processing": "",
            "search": "Procurar:",
            "zeroRecords": "Nenhum registro encontrado.",
            "paginate": {
                "first": "Primeiro",
                "last": "Último",
                "next": "Próximo",
                "previous": "Anterior"
            },
            "aria": {
                "orderable": "Crescente por esta coluna",
                "orderableReverse": "Decrescente por esta coluna"
            }
        }
    })

    setTimeout(function () {
        $(".alert").fadeOut("slow", function () {
            $(this).alert("close");
        })
    },5000)

});

