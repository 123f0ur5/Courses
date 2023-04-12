<!DOCTYPE html>
<html>
<head>
    <meta charset="utf-8"/>
    <title>Meu Redirect</title>

    <meta http-equiv="refresh" content="2; URL='./form_usuario.php'"/>
</head>
<body>
    Retornando para página de cadastro em 2 segundos...<br>
</body>
</html>

<?php

include_once("conexao.php");

$usuario = $_POST['usuario'];
$password = $_POST['password'];
$email = $_POST['email'];

$sql = "INSERT INTO tabela_usuario (usuario, senha, email) VALUES ('$usuario', '$password', '$email')";

if (mysqli_query($conexao, $sql)){
    echo "Gravou";
} else {
    echo "Não gravou" . mysqli_error(($conexao));
}

mysqli_close($conexao);

?>