<?php

session_start();

if(isset($_SESSION['sim'])){
	echo "Quantidade de sim: ".$_SESSION['sim'];
}

if(isset($_SESSION['nao'])){
	echo "<br>Quantidade de não: ".$_SESSION['nao'];
}

?>
<br><br>
<a href="index.php">Voltar</a>
<br>
<a href="limpar.php">Limpar</a>