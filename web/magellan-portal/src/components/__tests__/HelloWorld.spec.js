import { describe, it, expect } from 'vitest'

import { createI18n } from 'vue-i18n'

import { mount } from '@vue/test-utils'
import HelloWorld from '../HelloWorld.vue'

describe('HelloWorld', () => {
  it('renders properly', () => {
    const i18n = createI18n({
      messages: {
        en: {
          main: {
            hello: 'Hello World',
          },
        },
      },
    })

    const wrapper = mount(HelloWorld, {
      global: {
        plugins: [i18n],
      },
      props: { msg: 'Hello Vitest' },
    })

    expect(wrapper.text()).toContain('Hello Vitest')
    expect(wrapper.text()).toContain('Hello World')
  })
})
