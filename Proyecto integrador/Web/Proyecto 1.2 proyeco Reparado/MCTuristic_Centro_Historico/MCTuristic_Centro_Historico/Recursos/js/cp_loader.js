jQuery(document).ready(function($){var animationDuration=1000;var animated=true;function addEffectInView(){var counter=1;animationDelayCount=0;$(".cp_load").each(function(){var thiss=$(this);if(isScrolledIntoView(thiss)){animationDelayCount++;if(!thiss.hasClass("animated"))
setTimeout(function(){thiss.addClass("animated").removeClass("cp_load");},100*animationDelayCount);}});}
function isScrolledIntoView(elem){var docViewTop=$(window).scrollTop();var docViewBottom=docViewTop+ $(window).height();var elemTop=$(elem).offset().top;var elemBottom=elemTop+ $(elem).outerHeight(true);return((elemBottom<=docViewBottom)&&(elemTop>=docViewTop));}
var new_site_loader='disable';var new_element_loader='enable';if(new_element_loader=='enable'&&new_site_loader=='disable'){if(animated){setTimeout(function(){addEffectInView();var throttled2=_.throttle(addEffectInView,50);$(window).scroll(throttled2);},animationDuration*2);}else{$(".cp_load").removeClass("cp_load");}
$("#cp-preloader").remove();$("#cp-image-preloader").remove();}else{$(".cp_load").removeClass("cp_load");}});