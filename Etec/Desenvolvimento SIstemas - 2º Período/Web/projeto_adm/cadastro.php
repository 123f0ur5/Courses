<!DOCTYPE html>
<html>
<head>
    <meta charset="utf-8"/>
    <title>Meu Redirect</title>

    <meta http-equiv="refresh" content="2; URL='./form_cadastro.php'"/>
</head>
<body>
    Retornando para página de cadastro em 2 segundos...<br>
</body>
</html>

<?php

include_once("conexao.php");

$codigo = $_POST['codigo'];
$produto = $_POST['produto'];
$descricao = $_POST['descricao'];
$data = $_POST['data'];
$imagem = $_POST['imagem'];
$valor = $_POST['valor'];

$sql = "INSERT INTO tabelaimg (codigo, produto, descricao, data, imagem, valor) VALUES ('$codigo', '$produto', '$descricao', '$data', '$imagem', '$valor')";

if (mysqli_query($conexao, $sql)){
    echo "Gravou";
} else {
    echo "Não gravou" . mysqli_error(($conexao));
}

mysqli_close($conexao);

?>