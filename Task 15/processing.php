<?php
$output = '';
if ($_SERVER['REMOTE_ADDR']) {
  $output .= 'IP: '. $_SERVER['REMOTE_ADDR'];
}
else {
 $output .= 'IP unknown';
}
echo $output;
?>