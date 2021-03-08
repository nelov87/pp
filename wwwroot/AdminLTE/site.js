if (!window.TinyMce) {
    window.TinyMce = {};
}

window.TinyMce = {
    params : {
        standard: {
            plugins: 'code codesample link image autolink lists media paste table table spellchecker',
            toolbar1: 'undo redo | paste | removeformat styleselect | bold italic | alignleft aligncenter alignright alignjustify | outdent indent | link image media codesample | table | code | spellchecker',
            menubar: false,
            branding: false,
            toolbar_mode: 'floating'
        },
        minimal: {
            toolbar1: 'bold italic underline',
            menubar: false,
            branding: false,
            toolbar_mode: 'floating'
        },
        grouped: {
            plugins: "emoticons hr image link lists charmap table",
            toolbar: "formatgroup paragraphgroup insertgroup",
            toolbar_groups: {
                formatgroup: {
                    icon: 'format',
                    tooltip: 'Formatting',
                    items: 'bold italic underline strikethrough | forecolor backcolor | superscript subscript | removeformat'
                },
                paragraphgroup: {
                    icon: 'paragraph',
                    tooltip: 'Paragraph format',
                    items: 'h1 h2 h3 | bullist numlist | alignleft aligncenter alignright alignjustify | indent outdent'
                },
                insertgroup: {
                    icon: 'plus',
                    tooltip: 'Insert',
                    items: 'link image emoticons charmap hr'
                }
            },
            menubar: false,
            branding: false
        },
        bloated: {
            plugins: 'code codesample link image autolink lists media paste table table spellchecker',
            toolbar1: 'undo redo | styleselect | forecolor | bold italic underline strikethrough | link image media codesample | table | code | spellchecker',
            toolbar2: 'h1 h2 h3 | bullist numlist | alignleft aligncenter alignright alignjustify | outdent indent | emoticons charmap hr',
            menubar: false,
            branding: false,
            toolbar_mode: 'floating'
        }
    },
    init: function (id, mode, dotnetHelper) {
        var params = window.TinyMce.params[mode];
        params.selector = '#' + id;

        params.setup = function (editor) {
            editor.on('change', function (e) {
                console.log($('#' + id).val());
                $('#' + id).val(editor.getContent());
                $('#' + id).change();
                console.log($('#' + id).val());
                dotnetHelper.invokeMethodAsync("textArea_OnChange", $('#' + id).val());
            });
        }

        tinymce.init(params);
    },
    dispose: function (id, dotnetHelper) {
        tinymce.remove('#' + id);
    }
};