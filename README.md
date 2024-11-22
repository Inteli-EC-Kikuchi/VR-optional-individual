# VR-optional-individual


## Semana 1
Aplicativo que permite o usuário escolher entre 2 experiências envolvendo realidade virtual ou realidade aumentada.

### O que foi desenvolvido?

Desenvolvemos, nesta primeira semana, duas aplicações utilizando o framework `A-Frame` para realidade virtual e realidade aumentada. A primeira aplicação é um identificador de TAG que renderiza uma imagem e reproduz um som ao identificar a TAG. A segunda aplicação é o carregamento de imagens 360° para visualização em realidade virtual.

### Como foi implementada a experiência de realidade aumentada?

A experiência de realidade aumentada foi implementada utilizando AR.js, uma biblioteca baseada em Three.js integrada ao A-Frame, que simplifica o desenvolvimento de aplicações AR diretamente no navegador. Os principais pontos da implementação são:

    Uso de marcadores (markers):
        O marcador "hiro" é utilizado como ponto de ancoragem para exibir elementos de realidade aumentada no ambiente real.
        Quando o marcador é detectado pela câmera, os objetos associados são renderizados no espaço.

    Objetos e mídia:
        Um elemento de imagem (<a-image>) é renderizado sobre o marcador com rotação e posição configuradas.
        Um áudio (<a-entity sound>) é vinculado ao marcador para tocar automaticamente enquanto ele está visível.

    Componente personalizado:
        O componente controlador gerencia a reprodução do áudio, verificando constantemente (tick) se o marcador está visível:
            Se o marcador está visível, o áudio é reproduzido.
            Caso contrário, o áudio é pausado.

Esses elementos permitem a criação de uma experiência interativa e responsiva baseada na posição do marcador.

### Como foi implementada a experiência de realidade virtual?

A experiência de realidade virtual foi implementada utilizando o A-Frame, uma estrutura baseada em HTML para desenvolvimento VR. Os detalhes da implementação incluem:

    Ambiente 360°:
        O elemento <a-sky> define o cenário principal, configurando imagens panorâmicas como fundo em 360°.
        Cada cena utiliza uma imagem diferente para ambientar o usuário (ex.: "Malevolent Shrine" em vr.html e "Unlimited Void" em next.html).

    Interatividade com cursor:
        O <a-cursor>, vinculado à câmera (<a-camera>), permite a interação com elementos do cenário.
        O cursor responde a eventos como mouseenter para alterar a cena quando o usuário "olha" para o objeto interativo (esfera vermelha <a-sphere>).

    Transições entre cenas:
        Scripts JavaScript detectam o evento mouseenter na esfera interativa:
            Em vr.html, o clique redireciona para next.html.
            Em next.html, o clique redireciona de volta para vr.html.
        Isso cria uma navegação fluida entre as diferentes salas virtuais.

Esses elementos formam uma experiência imersiva com interações intuitivas, adaptada para dispositivos VR.