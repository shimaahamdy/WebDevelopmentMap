(function () {
    "use strict";
    window.addEventListener("load", function () {
        var box, div, script, namespaceURI;
        // First check whether the page contains any <math> element.
        namespaceURI = "http://www.w3.org/1998/Math/MathML";
        if (document.body.getElementsByTagNameNS(namespaceURI, "math")[0]) {
            // Create a div to test mspace, using Kuma's "offscreen" CSS
            document.body.insertAdjacentHTML("afterbegin", "<div style='border: 0; clip: rect(0 0 0 0); height: 1px; margin: -1px; overflow: hidden; padding: 0; position: absolute; width: 1px;'><math xmlns='" + namespaceURI + "'><mspace height='23px' width='77px'></mspace></math></div>");
            div = document.body.firstChild;
            box = div.firstChild.firstChild.getBoundingClientRect();
            document.body.removeChild(div);
            if (Math.abs(box.height - 23) > 1  || Math.abs(box.width - 77) > 1) {
                // Insert the MathJax.js script.
                script = document.createElement("script");
                script.src = "https://cdn.mathjax.org/mathjax/latest/MathJax.js?config=MML_HTMLorMML";
                document.head.appendChild(script);
            }
        }
    });
}());