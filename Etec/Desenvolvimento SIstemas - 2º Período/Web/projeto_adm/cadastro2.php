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

$sql = "INSERT INTO tabelaimg (codigo, produto, descricao, imagem, data, valor) VALUES ('$codigo', '$produto', '$descricao', '$imagem', '$data', '$valor')";

$resultado = mysqli_query($conexao, $sql);

if(!$resultado){
    die('Não foi possivel Gravar. Descrição: ' . mysqli_error($conexao));
}
else{
    echo "Registro criado com sucesso";
}

mysqli_close($conexao);















?>