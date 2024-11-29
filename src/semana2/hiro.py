from bark import SAMPLE_RATE, generate_audio, preload_models
from scipy.io.wavfile import write as write_wav
from IPython.display import Audio

# download and load all models
preload_models()

# A ideia é que Hiro seja um personagem confiante e bem humorado. Ele é um gênio da robótica e engenharia, e tem um jeito meio descolado de falar. Vamos criar um texto para ele e gerar um áudio com a voz dele.
text_prompt = """
     Oi! Eu sou o Hiro Hamada. Talvez você me conheça como o garoto dos Microbots. Eles são pequenos robôs que podem fazer praticamente qualquer coisa que você imaginar, só precisam de uma mente criativa pra guiá-los — o que, modéstia à parte, eu tenho de sobra. Eu cresci em San Fransokyo e sempre fui meio... digamos, precoce. Aos 14 anos, já era craque em engenharia e robótica. Parece legal, né? Bom, também me meti em algumas encrencas por aí, tipo... lutar robôs ilegalmente. Mas ei, foi uma boa escola!
"""
audio_array = generate_audio(text_prompt)

# save audio to disk
write_wav("bark_generation.wav", SAMPLE_RATE, audio_array)
  
# play text in notebook
Audio(audio_array, rate=SAMPLE_RATE)