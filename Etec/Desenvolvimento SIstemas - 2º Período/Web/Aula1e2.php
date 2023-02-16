<?php
echo "<center> <h1> Olá Mundo !!! <h1> </center>";
echo "<center> <h3> Moro na cidade de bariri </h3> </center>";
echo "<center> Rua Doutor José Augusto Arruda Botelho,264 </center>";
echo "<center> As férias foram ótimas! Arranjei uma namorada e vi um amigo distante. </center>";

$n1 = 3;
$n2 = 4;
$nome = "Luis";
$idade = 53;
echo "$nome tem $idade anos";
echo $n1 + $n2;
$nome = "Crébinho";
$idade = 7;
$salario = 50.50;
$casado = true;
$endereco = "Rua Campos Salles, 264";
$bairro = "Bairro da tiringa";
$cidade = "iclebinhotuba ";
$n1 = 50;
$n2 = -20;

if($casado){
    $casado = "é casado";
} else {
    $casado = "não é casado";
}


echo "$nome tem $idade anos, $nome ganha $salario reais, $nome $casado, e  mora na rua $endereco no $bairro na cidade de $cidade <br> <br>";
echo "O total da soma $n1  $n2 é igual a " . ($n1 + $n2);

?>
