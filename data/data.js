pageSize() ;
     function pageSize() {
        document.getElementById("Size").innerhtml = window.innerWidth + " x " + window.innerHeight;
    }

    window.addEventListener('resize', function(event) {
        pageSize();
    }, true);