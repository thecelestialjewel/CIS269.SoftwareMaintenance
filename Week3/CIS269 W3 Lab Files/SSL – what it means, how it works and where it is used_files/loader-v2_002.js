(function() {

    var __hs_cta_json = {"_id": "cta_button_70279_e40711a4-78d5-4553-8826-ecf53fde7635", "is_image": false, "image_html": "<a id=\"cta_button_70279_e40711a4-78d5-4553-8826-ecf53fde7635\" class=\"cta_button\" href=\"http://cta-service-cms2.hubspot.com/cs/c/?&cta_guid=e40711a4-78d5-4553-8826-ecf53fde7635&placement_guid=f0803db0-62da-474a-8871-d7ea09faad00&portal_id=70279&redirect_url=MH3UJ5e%2B7LMS8gwAwCBz6CQVc3OkTDyVQspXdwTER7dLHfPssL51rM24jHqdfEQm6pqgLPw0XzBIC1S1osZSuNyQqsmYX8BJnRUtPPyDCDc3UasnotYA%2BKhgrxVNi/0Z&iv=7VVeEDDxY4A%3D&hsutk=&canon=http%3A%2F%2Fwww.powersolution.com%2Fssl-what-it-means-how-it-works-whereused%2F\" cta_dest_link=\"http://info.powersolution.com/learn-how-our-it-support-plan-fits-your-business\">\n    <img id=\"hs-cta-img-f0803db0-62da-474a-8871-d7ea09faad00\" class=\"hs-cta-img \" style=\"border-width: 0px; /*hs-extra-styles*/\" mce_noresize=\"1\" alt=\"Request Complimentary Consultation\" src=\"//cdn2.hubspot.net/hubshot/14/02/21/de5379fa-15a7-49cd-9746-ec1755cf0e78.png\" />\n</a>", "raw_html": "<a id=\"cta_button_70279_e40711a4-78d5-4553-8826-ecf53fde7635\" class=\"cta_button \" href=\"http://cta-service-cms2.hubspot.com/cs/c/?&cta_guid=e40711a4-78d5-4553-8826-ecf53fde7635&placement_guid=f0803db0-62da-474a-8871-d7ea09faad00&portal_id=70279&redirect_url=MH3UJ5e%2B7LMS8gwAwCBz6CQVc3OkTDyVQspXdwTER7dLHfPssL51rM24jHqdfEQm6pqgLPw0XzBIC1S1osZSuNyQqsmYX8BJnRUtPPyDCDc3UasnotYA%2BKhgrxVNi/0Z&iv=7VVeEDDxY4A%3D&hsutk=&canon=http%3A%2F%2Fwww.powersolution.com%2Fssl-what-it-means-how-it-works-whereused%2F\" style=\"/*hs-extra-styles*/\" cta_dest_link=\"http://info.powersolution.com/learn-how-our-it-support-plan-fits-your-business\" title=\"Request Complimentary Consultation\">\n  Request Complimentary Consultation\n</a>", "_class": "hs-cta-f0803db0-62da-474a-8871-d7ea09faad00", "css": "a#cta_button_70279_e40711a4-78d5-4553-8826-ecf53fde7635 {-webkit-font-smoothing:antialiased !important;cursor:pointer !important;-moz-user-select:none !important;-webkit-user-select:none !important;-o-user-select:none !important;user-select:none !important;display:inline-block !important;font-weight:normal !important;text-align:center !important;text-decoration:none !important;width:auto !important;height:auto !important;font-family:sans-serif !important;background:rgb(0,69,147) !important;color:rgb(255,255,255) !important;border-radius:4px !important;border-width:0px !important;transition:all .4s ease !important;-moz-transition:all .4s ease !important;-webkit-transition:all .4s ease !important;-o-transition:all .4s ease !important;text-shadow:none !important;padding:4px 11px !important;font-size:14px !important;line-height:21px !important;}a#cta_button_70279_e40711a4-78d5-4553-8826-ecf53fde7635:hover {background:rgb(0,75,161) !important;color:rgb(255,255,255) !important;}a#cta_button_70279_e40711a4-78d5-4553-8826-ecf53fde7635:active, #cta_button_70279_e40711a4-78d5-4553-8826-ecf53fde7635:active:hover {background:rgb(0,55,117) !important;color:rgb(244,244,244) !important;}"};
    var __hs_cta = {};

    __hs_cta.drop = function() {
        var is_legacy = document.getElementById('hs-cta-ie-element') && true || false,
            html = __hs_cta_json.image_html,
            tags = __hs_cta.getTags(),
            is_image = __hs_cta_json.is_image,
            parent, _style;

        if (!is_legacy && !is_image) {
            parent = (document.getElementsByTagName("head")[0]||document.getElementsByTagName("body")[0]);

            _style = document.createElement('style');
            parent.insertBefore(_style, parent.childNodes[0]);
            try {
                // http://blog.coderlab.us/2005/09/22/using-the-innertext-property-with-firefox/
                _style[document.all ? 'innerText' : 'textContent'] = __hs_cta_json.css;
            } catch (e) {
                // addressing an ie9 issue
                _style.styleSheet.cssText = __hs_cta_json.css;
            }

            html = __hs_cta_json.raw_html;
        }

        for (var i = 0; i < tags.length; ++i) {

            var tag = tags[i];
            var images = tag.getElementsByTagName('img');
            var cssText = "";
            var align = "";
            for (var j = 0; j < images.length; j++) {
                align = images[j].align;
                images[j].style.border = '';
                images[j].style.display = '';
                cssText = images[j].style.cssText;
            }

            if (align == "right") {
                tag.style.display = "block";
                tag.style.textAlign = "right";
            } else if (align == "middle") {
                tag.style.display = "block";
                tag.style.textAlign = "center";
            }

            tag.innerHTML = html.replace('/*hs-extra-styles*/', cssText);
            tag.style.visibility = 'visible';

        }

        return tags;
    };

    __hs_cta.getTags = function() {
        var allTags, check, i, divTags, spanTags,
            tags = [];
            if (document.getElementsByClassName) {
                allTags = document.getElementsByClassName(__hs_cta_json._class);
                check = function(ele) {
                    return ele.nodeName == 'DIV' || ele.nodeName == 'SPAN';
                };
            } else {
                allTags = [];
                divTags = document.getElementsByTagName("div");
                spanTags = document.getElementsByTagName("span");
                for (i = 0; i < spanTags.length; i++) {
                    allTags.push(spanTags[i]);
                }
                for (i = 0; i < divTags.length; i++) {
                    allTags.push(divTags[i]);
                }

                check = function(ele) {
                    return ele.className.indexOf(__hs_cta_json._class) > -1;
                };
            }
            for (i = 0; i < allTags.length; ++i) {
                if (check(allTags[i])) {
                    tags.push(allTags[i]);
                }
            }
        return tags;
    };

    // need to do a slight timeout so IE has time to react
    setTimeout(__hs_cta.drop, 10);
}());