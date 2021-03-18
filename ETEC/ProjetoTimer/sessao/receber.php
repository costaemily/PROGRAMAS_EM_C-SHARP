<?php

$opcao = $_POST['opcao'];

//criar a váriavel de sessão para  armazenar o valor

session_start();

if(!isset($_SESSION['sim'])){
	$_SESSION['sim'] = 0;
}

if(!isset($_SESSION['nao'])){
	$_SESSION['nao'] = 0;
}


if($opcao == "sim"){
	$_SESSION['sim'] = $_SESSION['sim'] + 1;
}else{
	$_SESSION['nao'] = $_SESSION['nao'] + 1;
}
?>
<center>
<p>Voto Realizado com sucesso!</p><br>
<a href="index.php">Voltar</a>