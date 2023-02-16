<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="utf-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Média Notas</title>
</head>
<body>
    <style>
        input {
            margin-bottom: 5px;
        }
    </style>
    <h1>Média das Notas</h1>

    <form action="Aula4.php" method="post">
        <label for="nota1">Nota 1:<input name="nota1"></label><br>
        <label for="nota2">Nota 2:<input name="nota2"></label><br>
        <?php
            if ($_SERVER["REQUEST_METHOD"] == "POST") {
                $nota1 = $_POST['nota1'];
                $nota2 = $_POST['nota2'];
                $media = ($nota1 + $nota2) / 2;
                echo "Média de : $media<br>" ;
            }
        ?>
        <input type="submit" name="media" value="Calcular">
    </form>

    
</body>
</html>