<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
</head>
<body>
    <?php
    function op(){
        if(isset($_POST["somar"])){
            $n1 = $_POST['N1'];
            $n2 = $_POST['N2'];
            $result = $n1 + $n2;
            echo $result;
        } else if(isset($_POST["subtrair"])) {
            $n1 = $_POST['N1'];
            $n2 = $_POST['N2'];
            $result = $n1 - $n2;
            echo $result;
        } else if(isset($_POST["multiplicar"])) {
            $n1 = $_POST['N1'];
            $n2 = $_POST['N2'];
            $result = $n1 * $n2;
            echo $result;
        } else if(isset($_POST["dividir"])){
            $n1 = $_POST['N1'];
            $n2 = $_POST['N2'];
            $result = $n1 / $n2;
            echo $result;
        } else {
            echo "0";
        }
    }
    ?>
    <form method="post" action="">
        <label>N1:<input name="N1" id="N1" type="text"></label><br>
        <label>N2:<input name="N2" id="N2" type="text"></label><br>
        <label name="resultado">Resultado: <?php op() ?></label><br>
        <button name="somar" type="submit">Somar</button>
        <button name="subtrair" type="submit">Subtrair</button>
        <button name="multiplicar" type="submit">Multiplicar</button>
        <button name="dividir" type="submit">Dividir</button>
    </form>
</body>
</html>