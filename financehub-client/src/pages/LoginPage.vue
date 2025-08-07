<template>
  <div class="login-container">
    <h1 class="app-title">
      FinanceHub <font-awesome-icon :icon="faChartLine" class="icon-chart" />
    </h1>
    <div style="height: 1.5rem;"></div>
    <form @submit.prevent="handleLogin">
      <div class="form-group">
        <label for="email">E-mail</label>
        <input
          id="email"
          v-model="email"
          type="email"
          placeholder="Digite seu e-mail"
          required
        />
      </div>
      <div class="form-group">
        <label for="password">Senha</label>
        <input
          id="password"
          v-model="password"
          type="password"
          placeholder="Digite sua senha"
          required
        />
      </div>
      <button type="submit" :disabled="loading">
        {{ loading ? 'Entrando...' : 'Entrar' }}
      </button>
      <p v-if="error" class="error">{{ error }}</p>
    </form>
  </div>
</template>

<script>
import { faChartLine } from '@fortawesome/free-solid-svg-icons'
import { FontAwesomeIcon } from '@fortawesome/vue-fontawesome'

export default {
  name: 'LoginPage',
  components: { FontAwesomeIcon },
  data() {
    return {
      email: '',
      password: '',
      loading: false,
      error: '',
      faChartLine
    }
  },
  methods: {
    async handleLogin() {
      this.loading = true;
      this.error = '';
      try {
        // Exemplo de chamada de API (substitua pela sua integração real)
        // await this.$api.login(this.email, this.password);
        // Redirecionar após login bem-sucedido
        // this.$router.push('/dashboard');
        // Simulação de erro para exemplo
        if (this.email !== 'admin@admin.com' || this.password !== '123456') {
          throw new Error('E-mail ou senha inválidos');
        }
        alert('Login realizado com sucesso!');
      } catch (err) {
        this.error = err.message || 'Erro ao fazer login';
      } finally {
        this.loading = false;
      }
    }
  }
}
</script>

<style scoped>
.login-container {
  max-width: 350px;
  margin: 60px auto;
  padding: 2rem;
  border-radius: 8px;
  background: rgb(53, 71, 53);
  box-shadow: 0 2px 16px rgba(0,0,0,0.08);
}
.app-title {
  text-align: center;
  font-size: 2.2rem;
  font-weight: bold;
  color: rgb(36, 36, 36);
  margin-bottom: 0.5rem;
  letter-spacing: 1px;
}
.login-container h2 {
  text-align: center;
  margin-bottom: 1.5rem;
}
.form-group {
  margin-bottom: 1rem;
}
label {
  display: block;
  margin-bottom: 0.3rem;
  font-weight: 500;
  text-align: left;
  color: rgb(36, 36, 36);
}
input[type="email"],
input[type="password"] {
  width: 100%;
  padding: 0.5rem;
  border: 1px solid #ccc;
  border-radius: 4px;
  font-size: 1rem;
  box-sizing: border-box;
  background: rgb(36, 36, 36);
  color: #fff;
}
button {
  width: 100%;
  padding: 0.5rem;
  background: rgb(36, 36, 36);
  color: #fff;
  border: 2px solid #fff;
  border-radius: 4px;
  font-size: 1rem;
  cursor: pointer;
  transition: background 0.2s, border-color 0.2s;
  box-sizing: border-box;
}
button:focus,
button:active {
  border-color: transparent;
  outline: none;
}
button:disabled {
  background: #a0c4f7;
  cursor: not-allowed;
}
.error {
  color: #e74c3c;
  margin-top: 1rem;
  text-align: center;
}
.icon-chart {
  color: rgb(36, 36, 36);
  margin-left: 0.5rem;
  font-size: 0.8em;
  vertical-align: middle;
}
</style>
