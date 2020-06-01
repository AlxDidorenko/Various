<?php
$file=@file('result.txt');
$count=@implode('', $file);
$count++;
$myFile=fopen('result.txt', 'w');
fputs($myFile, $count);
fclose($myFile);
?>
<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>
    Attendance counter
    </title>
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <style type="text/css">
    body{
    font-family: 'Times New Roman', Times, serif;
    }
    .stuff{
    width: 80%;
    margin: 0 auto;
}
    </style>
</head>
<body>
    <div class="stuff">
        <h1>
        Attendance counter
        </h1>
        <p>count: <span><?=$count ?></span></p>
    </div>
</body>
</html>
