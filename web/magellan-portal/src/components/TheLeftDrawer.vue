<script setup>
import { defineProps } from 'vue'

const props = defineProps({
  open: Boolean,
})
</script>

<template>
  <q-drawer
    class="bg-grey-3"
    side="left"
    show-if-above
    :overlay="false"
    behavior="desktop"
    bordered
    :width="200"
    :breakpoint="500"
    :elevated="false"
    :mini="props.open"
  >
    <q-scroll-area class="fit">
      <q-list padding class="menu-list">
        <q-item clickable v-ripple to="/page1">
          <q-item-section avatar>
            <q-icon name="inbox" />
          </q-item-section>

          <q-item-section> Inbox </q-item-section>
        </q-item>

        <q-item clickable v-ripple to="/page2">
          <q-item-section avatar>
            <q-icon name="star" />
          </q-item-section>

          <q-item-section> Star </q-item-section>
        </q-item>

        <q-item clickable v-ripple to="/page3">
          <q-item-section avatar>
            <q-icon name="send" />
          </q-item-section>

          <q-item-section> Send </q-item-section>
        </q-item>
      </q-list>
    </q-scroll-area>
  </q-drawer>
</template>
