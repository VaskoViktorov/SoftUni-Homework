<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>First Steps Into PHP</title>
</head>
<body>
<form>
    N: <input type="text" name="num" />
    <input type="submit" />
</form>
<?php
if (isset($_GET['num'])) {

    $n1 = intval($_GET['num']);
    $a = 0;
    $b = 0;
    $c =1;
    echo "1 ";
    for($i=0 ; $i<$n1-1; $i++){

        $result = $b+$a+$c;
        $a = $b;
        $b = $c;
        $c = $result;
            echo "$result ";
    }
    if ($n1 == 0)
    {
        echo 1;
    }
}
?>

</body>
</html>



