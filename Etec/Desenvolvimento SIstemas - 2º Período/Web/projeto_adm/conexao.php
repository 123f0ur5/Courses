<?php
$nome_servidor = "localhost"; //127.0.0.1
$nome_usuario = "root";
$senha = "";
$nome_banco = "bd_pw2";
$conexao = mysqli_connect($nome_servidor, $nome_usuario, $senha, $nome_banco);

    if (mysqli_connect_error()){
    echo "Problemas com a conexão do Banco de Dados.". mysqli_connect_error();
}else{
    // echo "Conexão realizada com sucesso.";
}
?>